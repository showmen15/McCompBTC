CREATE TABLE [dbo].[Transactions]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [Btc] DECIMAL(18, 5) NOT NULL, 
    [IdUser] BIGINT NOT NULL, 
    [IdWallet] BIGINT NOT NULL
)
