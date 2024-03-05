CREATE TABLE [dbo].[MeetingNotes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MeetingId] INT NOT NULL, 
    [Note] VARCHAR(MAX) NOT NULL, 
    [UserId] INT NOT NULL
)
