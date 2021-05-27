CREATE TABLE [dbo].[Lector_Courses]
(
	[LectorId] INT NOT NULL, 
    [CourseId] int NOT NULL, 
    CONSTRAINT [FK_Lector_Courses_Lectors] FOREIGN KEY ([LectorId]) REFERENCES [Lectors]([id]), 
    CONSTRAINT [FK_Lector_Courses_Courses] FOREIGN KEY ([CourseId]) REFERENCES [Courses]([id]), 
    CONSTRAINT [PK_Lector_Courses] PRIMARY KEY ([LectorId], [CourseId]) 
)
