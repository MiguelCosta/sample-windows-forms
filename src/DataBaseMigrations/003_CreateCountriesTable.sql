-------------------------------------------------------------------------------
USE [MpcWinFormsIoCDataBase]
GO

DECLARE @version varchar(50) = '003';
DECLARE @description varchar(50) = 'Create Countries Table';
DECLARE @author varchar(50) = 'Miguel Costa';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Countries](
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Name] [nvarchar](255) NOT NULL,
  [Alias] [nvarchar](255) NOT NULL
  CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO
