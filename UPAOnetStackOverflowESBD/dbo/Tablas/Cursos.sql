CREATE TABLE [dbo].[Cursos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Nombre] NVARCHAR(50) NULL, 
	[Description] NVARCHAR(50) NULL, 
	[Capacidad] INT NULL 
)
