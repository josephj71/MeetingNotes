CREATE TABLE [dbo].[NoteActions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NoteId] INT NOT NULL, 
    [Action] VARCHAR(150) NOT NULL, 
    [AssignerId] INT NOT NULL, 
    [AssigneeId] INT NOT NULL, 
    [Status] VARCHAR(50) NOT NULL, 
    [StartDate] DATE NULL, 
    [DueDate] DATE NULL, 
    [CompletedDate] DATE NULL, 
    [CreateDate] DATE NOT NULL
)
