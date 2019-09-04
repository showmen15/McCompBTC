CREATE TABLE [dbo].[RegisterUsersPhones]
(
	[IdUser] BIGINT NOT NULL PRIMARY KEY, 
    [Phone] BIGINT NOT NULL, 
    CONSTRAINT [FK_RegisterUsersPhones_RegisterUsers] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[RegisterUsers]([IdUser])
)
