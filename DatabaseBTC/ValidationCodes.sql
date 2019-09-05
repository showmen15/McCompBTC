CREATE TABLE [dbo].[ValidationCodes]
(
	[IdCode] BIGINT NOT NULL PRIMARY KEY, 
	[IdUser]  BIGINT NOT NULL PRIMARY KEY,  
    CONSTRAINT [FK_ValidationCodes_RegisterUsers] FOREIGN KEY ([IdUser]) REFERENCES [RegisterUsers]([IdUser]), 
)
   
