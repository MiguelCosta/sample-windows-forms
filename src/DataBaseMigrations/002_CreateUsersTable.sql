-------------------------------------------------------------------------------
USE [MpcWinFormsIoCDataBase]
GO

DECLARE @version varchar(50) = '002';
DECLARE @description varchar(50) = 'Create Users Table';
DECLARE @author varchar(50) = 'Miguel Costa';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Users](
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Username] [nvarchar](255) NOT NULL,
  [Password] [nvarchar](255) NOT NULL,
  [Name] [nvarchar](255) NOT NULL,
  [Email] [nvarchar](255) NOT NULL,
  CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO

INSERT INTO [dbo].[Users]
    ([Username],[Password],[Name],[Email])
  VALUES
    ('system','0573915C3BDF76AB4F0A66CE5EA90E15787321ED','System User','miguelpintodacosta@gmail.com');
    -- password: system_123
GO
