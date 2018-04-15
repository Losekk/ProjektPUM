
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/15/2018 19:11:37
-- Generated from EDMX file: C:\Users\Damian\Desktop\Projekt\ProjectPUM\Model\MedBay.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MedBay];
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

-- Creating table 'CategorySet'
CREATE TABLE [dbo].[CategorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PictureFileName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductSet'
CREATE TABLE [dbo].[ProductSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [PictureFileName] nvarchar(max)  NOT NULL,
    [CategoryId] int  NOT NULL,
    [PriceId] int  NOT NULL
);
GO

-- Creating table 'PriceSet'
CREATE TABLE [dbo].[PriceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nett] float  NOT NULL,
    [Gross] float  NOT NULL,
    [Tax] float  NOT NULL
);
GO

-- Creating table 'WarehouseSet'
CREATE TABLE [dbo].[WarehouseSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] int  NOT NULL,
    [BookedQuantity] int  NOT NULL,
    [ProductId] int  NOT NULL
);
GO

-- Creating table 'CustomerSet'
CREATE TABLE [dbo].[CustomerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [MarketingAgreements] bit  NOT NULL,
    [AdressId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AdressSet'
CREATE TABLE [dbo].[AdressSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Street] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [PostalCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CartSet'
CREATE TABLE [dbo].[CartSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CreatedAt] nvarchar(max)  NOT NULL,
    [UpdatedAt] nvarchar(max)  NOT NULL,
    [CustomerId] int  NOT NULL
);
GO

-- Creating table 'CartItemSet'
CREATE TABLE [dbo].[CartItemSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CartId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Nett] nvarchar(max)  NOT NULL,
    [Gross] nvarchar(max)  NOT NULL,
    [Tax] nvarchar(max)  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderSet'
CREATE TABLE [dbo].[OrderSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [ShipNumber] nvarchar(max)  NOT NULL,
    [ShipCity] nvarchar(max)  NOT NULL,
    [ShipPostalCode] nvarchar(max)  NOT NULL,
    [CustomerComment] nvarchar(max)  NOT NULL,
    [UserComment] nvarchar(max)  NOT NULL,
    [Payments] nvarchar(max)  NOT NULL,
    [PaymentMethodId] int  NOT NULL,
    [TransportMethodId] int  NOT NULL,
    [IsPaid] bit  NOT NULL,
    [WasPaidAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL,
    [Net] nvarchar(max)  NOT NULL,
    [Gross] nvarchar(max)  NOT NULL,
    [Tax] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PaymentMethodSet'
CREATE TABLE [dbo].[PaymentMethodSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TransportMethodSet'
CREATE TABLE [dbo].[TransportMethodSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PriceId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CategorySet'
ALTER TABLE [dbo].[CategorySet]
ADD CONSTRAINT [PK_CategorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [PK_ProductSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [PK_PriceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WarehouseSet'
ALTER TABLE [dbo].[WarehouseSet]
ADD CONSTRAINT [PK_WarehouseSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [PK_CustomerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdressSet'
ALTER TABLE [dbo].[AdressSet]
ADD CONSTRAINT [PK_AdressSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CartSet'
ALTER TABLE [dbo].[CartSet]
ADD CONSTRAINT [PK_CartSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CartItemSet'
ALTER TABLE [dbo].[CartItemSet]
ADD CONSTRAINT [PK_CartItemSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderSet'
ALTER TABLE [dbo].[OrderSet]
ADD CONSTRAINT [PK_OrderSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PaymentMethodSet'
ALTER TABLE [dbo].[PaymentMethodSet]
ADD CONSTRAINT [PK_PaymentMethodSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TransportMethodSet'
ALTER TABLE [dbo].[TransportMethodSet]
ADD CONSTRAINT [PK_TransportMethodSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoryId] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [FK_CategoryProduct]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[CategorySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryProduct'
CREATE INDEX [IX_FK_CategoryProduct]
ON [dbo].[ProductSet]
    ([CategoryId]);
GO

-- Creating foreign key on [PriceId] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [FK_PriceProduct]
    FOREIGN KEY ([PriceId])
    REFERENCES [dbo].[PriceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PriceProduct'
CREATE INDEX [IX_FK_PriceProduct]
ON [dbo].[ProductSet]
    ([PriceId]);
GO

-- Creating foreign key on [PriceId] in table 'TransportMethodSet'
ALTER TABLE [dbo].[TransportMethodSet]
ADD CONSTRAINT [FK_PriceTransportMethod]
    FOREIGN KEY ([PriceId])
    REFERENCES [dbo].[PriceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PriceTransportMethod'
CREATE INDEX [IX_FK_PriceTransportMethod]
ON [dbo].[TransportMethodSet]
    ([PriceId]);
GO

-- Creating foreign key on [ProductId] in table 'WarehouseSet'
ALTER TABLE [dbo].[WarehouseSet]
ADD CONSTRAINT [FK_ProductWarehouse]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[ProductSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductWarehouse'
CREATE INDEX [IX_FK_ProductWarehouse]
ON [dbo].[WarehouseSet]
    ([ProductId]);
GO

-- Creating foreign key on [AdressId] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [FK_AdressCustomer]
    FOREIGN KEY ([AdressId])
    REFERENCES [dbo].[AdressSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdressCustomer'
CREATE INDEX [IX_FK_AdressCustomer]
ON [dbo].[CustomerSet]
    ([AdressId]);
GO

-- Creating foreign key on [UserId] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [FK_UserCustomer]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCustomer'
CREATE INDEX [IX_FK_UserCustomer]
ON [dbo].[CustomerSet]
    ([UserId]);
GO

-- Creating foreign key on [CustomerId] in table 'CartSet'
ALTER TABLE [dbo].[CartSet]
ADD CONSTRAINT [FK_CustomerCart]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerCart'
CREATE INDEX [IX_FK_CustomerCart]
ON [dbo].[CartSet]
    ([CustomerId]);
GO

-- Creating foreign key on [CustomerId] in table 'OrderSet'
ALTER TABLE [dbo].[OrderSet]
ADD CONSTRAINT [FK_CustomerOrder]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrder'
CREATE INDEX [IX_FK_CustomerOrder]
ON [dbo].[OrderSet]
    ([CustomerId]);
GO

-- Creating foreign key on [CartId] in table 'CartItemSet'
ALTER TABLE [dbo].[CartItemSet]
ADD CONSTRAINT [FK_CartCartItem]
    FOREIGN KEY ([CartId])
    REFERENCES [dbo].[CartSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CartCartItem'
CREATE INDEX [IX_FK_CartCartItem]
ON [dbo].[CartItemSet]
    ([CartId]);
GO

-- Creating foreign key on [ProductId] in table 'CartItemSet'
ALTER TABLE [dbo].[CartItemSet]
ADD CONSTRAINT [FK_ProductCartItem]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[ProductSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductCartItem'
CREATE INDEX [IX_FK_ProductCartItem]
ON [dbo].[CartItemSet]
    ([ProductId]);
GO

-- Creating foreign key on [PaymentMethodId] in table 'OrderSet'
ALTER TABLE [dbo].[OrderSet]
ADD CONSTRAINT [FK_PaymentMethodOrder]
    FOREIGN KEY ([PaymentMethodId])
    REFERENCES [dbo].[PaymentMethodSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaymentMethodOrder'
CREATE INDEX [IX_FK_PaymentMethodOrder]
ON [dbo].[OrderSet]
    ([PaymentMethodId]);
GO

-- Creating foreign key on [TransportMethodId] in table 'OrderSet'
ALTER TABLE [dbo].[OrderSet]
ADD CONSTRAINT [FK_TransportMethodOrder]
    FOREIGN KEY ([TransportMethodId])
    REFERENCES [dbo].[TransportMethodSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransportMethodOrder'
CREATE INDEX [IX_FK_TransportMethodOrder]
ON [dbo].[OrderSet]
    ([TransportMethodId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------