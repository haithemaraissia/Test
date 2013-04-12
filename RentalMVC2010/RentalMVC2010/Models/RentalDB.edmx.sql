
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/25/2013 16:24:10
-- Generated from EDMX file: C:\Users\h_a\Documents\GitHub\Test\RentalMVC2010\RentalMVC2010\Models\RentalDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RentalDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UnitGalleries'
CREATE TABLE [dbo].[UnitGalleries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NULL,
    [Caption] nvarchar(max)  NULL,
    [Rank] int  NOT NULL,
    [UnitId] int  NOT NULL
);
GO

-- Creating table 'Units'
CREATE TABLE [dbo].[Units] (
    [UnitId] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [State] nvarchar(max)  NULL,
    [Bed] int  NOT NULL,
    [Bathroom] float  NOT NULL,
    [SquareFoot] float  NOT NULL,
    [YearBuilt] int  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [PrimaryImagePath] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UnitGalleries'
ALTER TABLE [dbo].[UnitGalleries]
ADD CONSTRAINT [PK_UnitGalleries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UnitId] in table 'Units'
ALTER TABLE [dbo].[Units]
ADD CONSTRAINT [PK_Units]
    PRIMARY KEY CLUSTERED ([UnitId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UnitId] in table 'UnitGalleries'
ALTER TABLE [dbo].[UnitGalleries]
ADD CONSTRAINT [FK_dbo_UnitGalleries_dbo_Units_Unit_UnitId1]
    FOREIGN KEY ([UnitId])
    REFERENCES [dbo].[Units]
        ([UnitId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UnitGalleries_dbo_Units_Unit_UnitId1'
CREATE INDEX [IX_FK_dbo_UnitGalleries_dbo_Units_Unit_UnitId1]
ON [dbo].[UnitGalleries]
    ([UnitId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------