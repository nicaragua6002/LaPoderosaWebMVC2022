
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2019 13:34:26
-- Generated from EDMX file: C:\Users\solis\source\repos\LaPoderosaWebMVC\LaPoderosaWebMVC\Models\LaPoderosaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LaPoderosaBD];
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

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Productos'
CREATE TABLE [dbo].[Productos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreProducto] nvarchar(max)  NOT NULL,
    [CantidadPorUnidad] nvarchar(max)  NOT NULL,
    [PrecioUnidad] decimal(18,0)  NOT NULL,
    [UnidadEnExistencia] smallint  NOT NULL,
    [img] varbinary(max)  NULL,
    [ProveedorId] int  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Recetas'
CREATE TABLE [dbo].[Recetas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreReceta] nvarchar(max)  NOT NULL,
    [Preparacion] nvarchar(max)  NOT NULL,
    [img] varbinary(max)  NULL
);
GO

-- Creating table 'Ingredientes'
CREATE TABLE [dbo].[Ingredientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Porcion] nvarchar(max)  NOT NULL,
    [RecetaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [PK_Productos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recetas'
ALTER TABLE [dbo].[Recetas]
ADD CONSTRAINT [PK_Recetas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ingredientes'
ALTER TABLE [dbo].[Ingredientes]
ADD CONSTRAINT [PK_Ingredientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProveedorId] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_ProveedorProducto]
    FOREIGN KEY ([ProveedorId])
    REFERENCES [dbo].[Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorProducto'
CREATE INDEX [IX_FK_ProveedorProducto]
ON [dbo].[Productos]
    ([ProveedorId]);
GO

-- Creating foreign key on [CategoriaId] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_CategoriaProducto]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaProducto'
CREATE INDEX [IX_FK_CategoriaProducto]
ON [dbo].[Productos]
    ([CategoriaId]);
GO

-- Creating foreign key on [RecetaId] in table 'Ingredientes'
ALTER TABLE [dbo].[Ingredientes]
ADD CONSTRAINT [FK_RecetaIngrediente]
    FOREIGN KEY ([RecetaId])
    REFERENCES [dbo].[Recetas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecetaIngrediente'
CREATE INDEX [IX_FK_RecetaIngrediente]
ON [dbo].[Ingredientes]
    ([RecetaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------