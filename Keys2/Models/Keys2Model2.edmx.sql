
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/29/2018 08:33:06
-- Generated from EDMX file: C:\Users\princ\source\repos\Keys2\Keys2\Models\Keys2Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MVC];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerProductSold]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSolds] DROP CONSTRAINT [FK_CustomerProductSold];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductProductSold]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSolds] DROP CONSTRAINT [FK_ProductProductSold];
GO
IF OBJECT_ID(N'[dbo].[FK_StoreProductSold]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSolds] DROP CONSTRAINT [FK_StoreProductSold];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductSolds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductSolds];
GO
IF OBJECT_ID(N'[dbo].[Stores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stores];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductSolds'
CREATE TABLE [dbo].[ProductSolds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [StoreId] int  NOT NULL,
    [DateSold] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Stores'
CREATE TABLE [dbo].[Stores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductSolds'
ALTER TABLE [dbo].[ProductSolds]
ADD CONSTRAINT [PK_ProductSolds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Stores'
ALTER TABLE [dbo].[Stores]
ADD CONSTRAINT [PK_Stores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'ProductSolds'
ALTER TABLE [dbo].[ProductSolds]
ADD CONSTRAINT [FK_CustomerProductSold]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerProductSold'
CREATE INDEX [IX_FK_CustomerProductSold]
ON [dbo].[ProductSolds]
    ([CustomerId]);
GO

-- Creating foreign key on [ProductId] in table 'ProductSolds'
ALTER TABLE [dbo].[ProductSolds]
ADD CONSTRAINT [FK_ProductProductSold]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductProductSold'
CREATE INDEX [IX_FK_ProductProductSold]
ON [dbo].[ProductSolds]
    ([ProductId]);
GO

-- Creating foreign key on [StoreId] in table 'ProductSolds'
ALTER TABLE [dbo].[ProductSolds]
ADD CONSTRAINT [FK_StoreProductSold]
    FOREIGN KEY ([StoreId])
    REFERENCES [dbo].[Stores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StoreProductSold'
CREATE INDEX [IX_FK_StoreProductSold]
ON [dbo].[ProductSolds]
    ([StoreId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------