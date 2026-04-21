USE [master];
GO

IF DB_ID(N'SklepInternetowy') IS NOT NULL
BEGIN
    ALTER DATABASE [SklepInternetowy] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [SklepInternetowy];
END
GO

CREATE DATABASE [SklepInternetowy];
GO

ALTER DATABASE [SklepInternetowy] SET RECOVERY SIMPLE;
GO

USE [SklepInternetowy];
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

CREATE TABLE [dbo].[Uzytkownicy] (
    [ID_Uzytkownika] INT IDENTITY(1,1) NOT NULL,
    [Email] VARCHAR(100) NOT NULL,
    [HasloHash] VARCHAR(255) NOT NULL,
    [Imie] VARCHAR(50) NULL,
    [Nazwisko] VARCHAR(50) NULL,
    [Telefon] VARCHAR(20) NULL,
    [Rola] VARCHAR(20) NULL CONSTRAINT [DF_Uzytkownicy_Rola] DEFAULT ('Klient'),
    [NewsletterZgoda] BIT NULL CONSTRAINT [DF_Uzytkownicy_NewsletterZgoda] DEFAULT ((0)),
    [DataRejestracji] DATETIME NULL CONSTRAINT [DF_Uzytkownicy_DataRejestracji] DEFAULT (GETDATE()),
    CONSTRAINT [PK_Uzytkownicy] PRIMARY KEY CLUSTERED ([ID_Uzytkownika] ASC),
    CONSTRAINT [UQ_Uzytkownicy_Email] UNIQUE NONCLUSTERED ([Email] ASC)
);
GO

CREATE TABLE [dbo].[Kategorie] (
    [ID_Kategorii] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(100) NOT NULL,
    [ID_Rodzica] INT NULL,
    CONSTRAINT [PK_Kategorie] PRIMARY KEY CLUSTERED ([ID_Kategorii] ASC)
);
GO

CREATE TABLE [dbo].[Kolory] (
    [ID_Koloru] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_Kolory] PRIMARY KEY CLUSTERED ([ID_Koloru] ASC)
);
GO

CREATE TABLE [dbo].[Marki] (
    [ID_Marki] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(100) NOT NULL,
    [Opis] VARCHAR(500) NULL,
    CONSTRAINT [PK_Marki] PRIMARY KEY CLUSTERED ([ID_Marki] ASC)
);
GO

CREATE TABLE [dbo].[Materialy] (
    [ID_Materialu] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Materialy] PRIMARY KEY CLUSTERED ([ID_Materialu] ASC)
);
GO

CREATE TABLE [dbo].[MetodyDostawy] (
    [ID_Dostawy] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(100) NOT NULL,
    [Cena] DECIMAL(10,2) NOT NULL,
    CONSTRAINT [PK_MetodyDostawy] PRIMARY KEY CLUSTERED ([ID_Dostawy] ASC)
);
GO

CREATE TABLE [dbo].[MetodyPlatnosci] (
    [ID_Metody] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_MetodyPlatnosci] PRIMARY KEY CLUSTERED ([ID_Metody] ASC)
);
GO

CREATE TABLE [dbo].[Rozmiary] (
    [ID_Rozmiaru] INT IDENTITY(1,1) NOT NULL,
    [Symbol] VARCHAR(10) NOT NULL,
    [Typ] VARCHAR(20) NULL,
    CONSTRAINT [PK_Rozmiary] PRIMARY KEY CLUSTERED ([ID_Rozmiaru] ASC)
);
GO

CREATE TABLE [dbo].[StatusyZamowienia] (
    [ID_Statusu] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_StatusyZamowienia] PRIMARY KEY CLUSTERED ([ID_Statusu] ASC)
);
GO

CREATE TABLE [dbo].[Produkty] (
    [ID_Produktu] INT IDENTITY(1,1) NOT NULL,
    [Nazwa] VARCHAR(200) NOT NULL,
    [Opis] VARCHAR(1000) NULL,
    [ID_Marki] INT NOT NULL,
    [ID_Kategorii] INT NOT NULL,
    [Plec] VARCHAR(20) NULL,
    [PrzepisPrania] VARCHAR(255) NULL,
    [CenaBazowa] DECIMAL(10,2) NOT NULL,
    [DataDodania] DATETIME NULL CONSTRAINT [DF_Produkty_DataDodania] DEFAULT (GETDATE()),
    CONSTRAINT [PK_Produkty] PRIMARY KEY CLUSTERED ([ID_Produktu] ASC)
);
GO

CREATE TABLE [dbo].[Adresy] (
    [ID_Adresu] INT IDENTITY(1,1) NOT NULL,
    [ID_Uzytkownika] INT NOT NULL,
    [Ulica] VARCHAR(100) NULL,
    [Miasto] VARCHAR(50) NULL,
    [KodPocztowy] VARCHAR(10) NULL,
    [Kraj] VARCHAR(50) NULL CONSTRAINT [DF_Adresy_Kraj] DEFAULT ('Polska'),
    CONSTRAINT [PK_Adresy] PRIMARY KEY CLUSTERED ([ID_Adresu] ASC)
);
GO

CREATE TABLE [dbo].[WariantyProduktu] (
    [ID_Wariantu] INT IDENTITY(1,1) NOT NULL,
    [ID_Produktu] INT NOT NULL,
    [ID_Rozmiaru] INT NOT NULL,
    [ID_Koloru] INT NOT NULL,
    [StanMagazynowy] INT NULL CONSTRAINT [DF_WariantyProduktu_StanMagazynowy] DEFAULT ((0)),
    [KodEAN] VARCHAR(20) NULL,
    CONSTRAINT [PK_WariantyProduktu] PRIMARY KEY CLUSTERED ([ID_Wariantu] ASC)
);
GO

CREATE TABLE [dbo].[Zamowienia] (
    [ID_Zamowienia] INT IDENTITY(1,1) NOT NULL,
    [ID_Uzytkownika] INT NULL,
    [ID_Statusu] INT NOT NULL,
    [ID_MetodyPlatnosci] INT NOT NULL,
    [ID_Dostawy] INT NOT NULL,
    [ID_Adresu] INT NOT NULL,
    [DataZamowienia] DATETIME NULL CONSTRAINT [DF_Zamowienia_DataZamowienia] DEFAULT (GETDATE()),
    [WartoscCalkowita] DECIMAL(10,2) NULL CONSTRAINT [DF_Zamowienia_WartoscCalkowita] DEFAULT ((0)),
    CONSTRAINT [PK_Zamowienia] PRIMARY KEY CLUSTERED ([ID_Zamowienia] ASC)
);
GO

CREATE TABLE [dbo].[Faktury] (
    [ID_Faktury] INT IDENTITY(1,1) NOT NULL,
    [ID_Zamowienia] INT NOT NULL,
    [NumerFaktury] VARCHAR(50) NOT NULL,
    [NIP_Nabywcy] VARCHAR(20) NULL,
    [DataWystawienia] DATETIME NULL CONSTRAINT [DF_Faktury_DataWystawienia] DEFAULT (GETDATE()),
    CONSTRAINT [PK_Faktury] PRIMARY KEY CLUSTERED ([ID_Faktury] ASC)
);
GO

CREATE TABLE [dbo].[ListyZyczen] (
    [ID_Listy] INT IDENTITY(1,1) NOT NULL,
    [ID_Uzytkownika] INT NOT NULL,
    [ID_Produktu] INT NOT NULL,
    [DataDodania] DATETIME NULL CONSTRAINT [DF_ListyZyczen_DataDodania] DEFAULT (GETDATE()),
    CONSTRAINT [PK_ListyZyczen] PRIMARY KEY CLUSTERED ([ID_Listy] ASC)
);
GO

CREATE TABLE [dbo].[Opinie] (
    [ID_Opinii] INT IDENTITY(1,1) NOT NULL,
    [ID_Produktu] INT NOT NULL,
    [ID_Uzytkownika] INT NOT NULL,
    [Ocena] INT NULL,
    [Tresc] VARCHAR(MAX) NULL,
    [DataWystawienia] DATETIME NULL CONSTRAINT [DF_Opinie_DataWystawienia] DEFAULT (GETDATE()),
    CONSTRAINT [PK_Opinie] PRIMARY KEY CLUSTERED ([ID_Opinii] ASC)
);
GO

CREATE TABLE [dbo].[PozycjeZamowienia] (
    [ID_Pozycji] INT IDENTITY(1,1) NOT NULL,
    [ID_Zamowienia] INT NOT NULL,
    [ID_Wariantu] INT NOT NULL,
    [Ilosc] INT NOT NULL,
    [CenaJednostkowa] DECIMAL(10,2) NOT NULL,
    CONSTRAINT [PK_PozycjeZamowienia] PRIMARY KEY CLUSTERED ([ID_Pozycji] ASC)
);
GO

CREATE TABLE [dbo].[ProduktyMaterialy] (
    [ID_PM] INT IDENTITY(1,1) NOT NULL,
    [ID_Produktu] INT NOT NULL,
    [ID_Materialu] INT NOT NULL,
    [ProcentSkladu] INT NULL,
    CONSTRAINT [PK_ProduktyMaterialy] PRIMARY KEY CLUSTERED ([ID_PM] ASC)
);
GO

CREATE TABLE [dbo].[Przesylki] (
    [ID_Przesylki] INT IDENTITY(1,1) NOT NULL,
    [ID_Zamowienia] INT NOT NULL,
    [NumerListuPrzewozowego] VARCHAR(100) NULL,
    [LinkDoSledzenia] VARCHAR(255) NULL,
    [DataNadania] DATETIME NULL CONSTRAINT [DF_Przesylki_DataNadania] DEFAULT (GETDATE()),
    CONSTRAINT [PK_Przesylki] PRIMARY KEY CLUSTERED ([ID_Przesylki] ASC)
);
GO

CREATE TABLE [dbo].[Zdjecia] (
    [ID_Zdjecia] INT IDENTITY(1,1) NOT NULL,
    [ID_Produktu] INT NOT NULL,
    [URL] VARCHAR(255) NULL,
    [CzyGlowne] BIT NULL CONSTRAINT [DF_Zdjecia_CzyGlowne] DEFAULT ((0)),
    CONSTRAINT [PK_Zdjecia] PRIMARY KEY CLUSTERED ([ID_Zdjecia] ASC)
);
GO

CREATE TABLE [dbo].[Zwroty] (
    [ID_Zwrotu] INT IDENTITY(1,1) NOT NULL,
    [ID_Zamowienia] INT NOT NULL,
    [Powod] VARCHAR(MAX) NULL,
    [StatusZwrotu] VARCHAR(50) NULL CONSTRAINT [DF_Zwroty_StatusZwrotu] DEFAULT ('Zgloszony'),
    CONSTRAINT [PK_Zwroty] PRIMARY KEY CLUSTERED ([ID_Zwrotu] ASC)
);
GO

ALTER TABLE [dbo].[Kategorie]
ADD CONSTRAINT [FK_Kategorie_Kategorie]
FOREIGN KEY ([ID_Rodzica]) REFERENCES [dbo].[Kategorie]([ID_Kategorii]);
GO

ALTER TABLE [dbo].[Adresy]
ADD CONSTRAINT [FK_Adresy_Uzytkownicy]
FOREIGN KEY ([ID_Uzytkownika]) REFERENCES [dbo].[Uzytkownicy]([ID_Uzytkownika]);
GO

ALTER TABLE [dbo].[Produkty]
ADD CONSTRAINT [FK_Produkty_Marki]
FOREIGN KEY ([ID_Marki]) REFERENCES [dbo].[Marki]([ID_Marki]);
GO

ALTER TABLE [dbo].[Produkty]
ADD CONSTRAINT [FK_Produkty_Kategorie]
FOREIGN KEY ([ID_Kategorii]) REFERENCES [dbo].[Kategorie]([ID_Kategorii]);
GO

ALTER TABLE [dbo].[WariantyProduktu]
ADD CONSTRAINT [FK_WariantyProduktu_Produkty]
FOREIGN KEY ([ID_Produktu]) REFERENCES [dbo].[Produkty]([ID_Produktu]);
GO

ALTER TABLE [dbo].[WariantyProduktu]
ADD CONSTRAINT [FK_WariantyProduktu_Rozmiary]
FOREIGN KEY ([ID_Rozmiaru]) REFERENCES [dbo].[Rozmiary]([ID_Rozmiaru]);
GO

ALTER TABLE [dbo].[WariantyProduktu]
ADD CONSTRAINT [FK_WariantyProduktu_Kolory]
FOREIGN KEY ([ID_Koloru]) REFERENCES [dbo].[Kolory]([ID_Koloru]);
GO

ALTER TABLE [dbo].[ProduktyMaterialy]
ADD CONSTRAINT [FK_ProduktyMaterialy_Produkty]
FOREIGN KEY ([ID_Produktu]) REFERENCES [dbo].[Produkty]([ID_Produktu]);
GO

ALTER TABLE [dbo].[ProduktyMaterialy]
ADD CONSTRAINT [FK_ProduktyMaterialy_Materialy]
FOREIGN KEY ([ID_Materialu]) REFERENCES [dbo].[Materialy]([ID_Materialu]);
GO

ALTER TABLE [dbo].[ListyZyczen]
ADD CONSTRAINT [FK_ListyZyczen_Uzytkownicy]
FOREIGN KEY ([ID_Uzytkownika]) REFERENCES [dbo].[Uzytkownicy]([ID_Uzytkownika]);
GO

ALTER TABLE [dbo].[ListyZyczen]
ADD CONSTRAINT [FK_ListyZyczen_Produkty]
FOREIGN KEY ([ID_Produktu]) REFERENCES [dbo].[Produkty]([ID_Produktu]);
GO

ALTER TABLE [dbo].[Opinie]
ADD CONSTRAINT [FK_Opinie_Uzytkownicy]
FOREIGN KEY ([ID_Uzytkownika]) REFERENCES [dbo].[Uzytkownicy]([ID_Uzytkownika]);
GO

ALTER TABLE [dbo].[Opinie]
ADD CONSTRAINT [FK_Opinie_Produkty]
FOREIGN KEY ([ID_Produktu]) REFERENCES [dbo].[Produkty]([ID_Produktu]);
GO

ALTER TABLE [dbo].[Zamowienia]
ADD CONSTRAINT [FK_Zamowienia_Uzytkownicy]
FOREIGN KEY ([ID_Uzytkownika]) REFERENCES [dbo].[Uzytkownicy]([ID_Uzytkownika]);
GO

ALTER TABLE [dbo].[Zamowienia]
ADD CONSTRAINT [FK_Zamowienia_StatusyZamowienia]
FOREIGN KEY ([ID_Statusu]) REFERENCES [dbo].[StatusyZamowienia]([ID_Statusu]);
GO

ALTER TABLE [dbo].[Zamowienia]
ADD CONSTRAINT [FK_Zamowienia_MetodyPlatnosci]
FOREIGN KEY ([ID_MetodyPlatnosci]) REFERENCES [dbo].[MetodyPlatnosci]([ID_Metody]);
GO

ALTER TABLE [dbo].[Zamowienia]
ADD CONSTRAINT [FK_Zamowienia_MetodyDostawy]
FOREIGN KEY ([ID_Dostawy]) REFERENCES [dbo].[MetodyDostawy]([ID_Dostawy]);
GO

ALTER TABLE [dbo].[Zamowienia]
ADD CONSTRAINT [FK_Zamowienia_Adresy]
FOREIGN KEY ([ID_Adresu]) REFERENCES [dbo].[Adresy]([ID_Adresu]);
GO

ALTER TABLE [dbo].[PozycjeZamowienia]
ADD CONSTRAINT [FK_PozycjeZamowienia_Zamowienia]
FOREIGN KEY ([ID_Zamowienia]) REFERENCES [dbo].[Zamowienia]([ID_Zamowienia]);
GO

ALTER TABLE [dbo].[PozycjeZamowienia]
ADD CONSTRAINT [FK_PozycjeZamowienia_WariantyProduktu]
FOREIGN KEY ([ID_Wariantu]) REFERENCES [dbo].[WariantyProduktu]([ID_Wariantu]);
GO

ALTER TABLE [dbo].[Faktury]
ADD CONSTRAINT [FK_Faktury_Zamowienia]
FOREIGN KEY ([ID_Zamowienia]) REFERENCES [dbo].[Zamowienia]([ID_Zamowienia]);
GO

ALTER TABLE [dbo].[Przesylki]
ADD CONSTRAINT [FK_Przesylki_Zamowienia]
FOREIGN KEY ([ID_Zamowienia]) REFERENCES [dbo].[Zamowienia]([ID_Zamowienia]);
GO

ALTER TABLE [dbo].[Zdjecia]
ADD CONSTRAINT [FK_Zdjecia_Produkty]
FOREIGN KEY ([ID_Produktu]) REFERENCES [dbo].[Produkty]([ID_Produktu]);
GO

ALTER TABLE [dbo].[Zwroty]
ADD CONSTRAINT [FK_Zwroty_Zamowienia]
FOREIGN KEY ([ID_Zamowienia]) REFERENCES [dbo].[Zamowienia]([ID_Zamowienia]);
GO