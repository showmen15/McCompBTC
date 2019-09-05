﻿CREATE TABLE [dbo].[Transactions]
(
	[Id] BIGINT IDENTITY(1,1)  NOT NULL PRIMARY KEY, 
    [Btc] DECIMAL(18, 5) NOT NULL, 
    [IdUser] BIGINT NOT NULL, 
    [IdWallet] BIGINT NOT NULL
)
