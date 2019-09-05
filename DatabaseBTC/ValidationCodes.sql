CREATE TABLE [dbo].[ValidationCodes](
	[IdUser] [bigint]  NOT NULL,
	[IdCode] [bigint]  IDENTITY(1,1) NOT NULL PRIMARY KEY
	--, 
    --CONSTRAINT [FK_ValidationCodes_RegisterUsers] FOREIGN KEY ([IdUser]) REFERENCES [RegisterUsers]([IdUser])
)
GO