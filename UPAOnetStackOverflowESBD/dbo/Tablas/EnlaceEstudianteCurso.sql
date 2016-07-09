CREATE TABLE [dbo].[EnlaceEstudianteCurso]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[EstudianteID] INT NOT NULL, 
	[CursoID] INT NOT NULL, 
	CONSTRAINT [FK_EnlaceEstudianteCurso_Estudiante] FOREIGN KEY (EstudianteID) REFERENCES Estudiante(Id), 
	CONSTRAINT [FK_EnlaceEstudianteCurso_Curso] FOREIGN KEY (CursoID) REFERENCES Cursos(Id)
)
