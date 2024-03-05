CREATE TABLE [dbo].[Meetings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MeetingName] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [MeetingDate] DATETIME2 NOT NULL
)
