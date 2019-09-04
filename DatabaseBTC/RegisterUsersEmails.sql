CREATE TABLE [dbo].[RegisterUsersEmails]
(
	[IdUser] BIGINT NOT NULL PRIMARY KEY, 
    [Email] NVARCHAR(MAX) NOT NULL, 
    
    CONSTRAINT [FK_RegisterUsersEmails_RegisterUsers] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[RegisterUsers]([IdUser])
)
