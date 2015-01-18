-- =========================================
-- Create FileTable template
-- =========================================
CREATE TABLE[Numismatist](

        [Name][varchar](30) NOT NULL,

        [TelephoneNumber][varchar](11) NOT NULL,

        [CollectionName][varchar](30) NOT NULL,

        [SellerName][varchar] NOT NULL,

CONSTRAINT [PK_Numismatist] PRIMARY KEY ([Name] ASC)

)

CREATE TABLE[Seller](

        [Name][varchar](30) NOT NULL,

        [TelephoneNumber][varchar](11) NOT NULL,

        [CollectionName][varchar](30) NOT NULL,

        [NumismatistName][varchar] NOT NULL,

CONSTRAINT [PK_Seller] PRIMARY KEY ([Name] ASC)

)

CREATE TABLE[Collection](

        [Name][varchar](10) NOT NULL,

        [Comment][varchar](100) NOT NULL,

        [NumismatistName][varchar] NOT NULL,

CONSTRAINT [PK_Collection] PRIMARY KEY ([Name] ASC)        

)

CREATE TABLE[Seller_Collection](

        [Name][varchar](10) NOT NULL,

        [Comment][varchar](100) NOT NULL,

        [SellerName][varchar] NOT NULL,

CONSTRAINT [PK_Seller_Collection] PRIMARY KEY ([Name] ASC)        

)

CREATE TABLE[Coin](

        [Name][varchar](15) NOT NULL,

        [Nominal][varchar](10) NOT NULL,

        [Country][varchar](20) NOT NULL,

        [Year][varchar](4) NOT NULL,

        [CollectionName][varchar] NOT NULL,

CONSTRAINT [PK_Coin] PRIMARY KEY ([Name] ASC)

)

CREATE TABLE[Sell_Coin](

   [Id] [int] NOT NULL,

        [Cost][varchar](15) NOT NULL,

        [CoinName][varchar] NOT NULL,

        [SellerCollectionName][varchar] NOT NULL,

CONSTRAINT [PK_Sell_Coin] PRIMARY KEY ([Id] ASC)

)

CREATE TABLE[Coin_Copy](

   [Id] [int] NOT NULL,

        [CoinCopy][varchar](20) NOT NULL,

        [Quantity][int](15) NOT NULL,

        [CoinName][varchar] NOT NULL,

CONSTRAINT [PK_Coin_Copy] PRIMARY KEY ([Id] ASC)

)

ALTER TABLE [Collection] ADD CONSTRAINT [FK_Collection_Numismatist] 

FOREIGN KEY([NumismatistName]) REFERENCES [Numismatist] ([Name]) ON DELETE CASCADE

ALTER TABLE [Seller_collection] ADD CONSTRAINT [FK_Seller_Collection_Seller] 

FOREIGN KEY([SellerName]) REFERENCES [Seller] ([Name]) ON DELETE CASCADE

ALTER TABLE [Coin] ADD CONSTRAINT [FK_Coin_Collection] 

FOREIGN KEY([CollectionName]) REFERENCES [Collection] ([Name]) ON UPDATE CASCADE

ALTER TABLE [Sell_Coin] ADD CONSTRAINT [FK_Sell_Coin_Seller_Collection] 

FOREIGN KEY([SellerCollectionName]) REFERENCES [Seller_Collection] ([Name]) ON UPDATE CASCADE

ALTER TABLE [Copy_of_Coin] ADD CONSTRAINT [FK_Copy_of_Coin_Coin] 

FOREIGN KEY([CoinName]) REFERENCES [Coin] ([Name]) ON UPDATE CASCADE

ALTER TABLE [Sell_Coin] ADD CONSTRAINT [FK_Sell_Coin_Coin] 

FOREIGN KEY([CoinName]) REFERENCES [Coin] ([Name]) ON UPDATE CASCADE

ALTER TABLE [Sell_Coin] ADD CONSTRAINT [FK_Sell_Coin_Coin] 

FOREIGN KEY([CoinName]) REFERENCES [Coin] ([Name]) ON DELETE CASCADE
