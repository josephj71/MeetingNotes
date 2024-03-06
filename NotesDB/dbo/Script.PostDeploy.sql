if not exists(select 1 from dbo.[Users])
begin
	
	Insert into Users (FirstName, LastName)
	Values ('Joe', 'Johnson'),
	('John', 'Doe'),
	('Jane', 'Doe'),
	('Lucy', 'Doe')
end

if not exists (Select 1 from dbo.Meetings)
begin

	insert into  Meetings (MeetingName, Description, MeetingDate)
	Values ('Test Meeting 1', 'First test meeting', '2024-03-03'),
	('Test Meeting 2', 'Second test meeting', '2024-03-04'),
	('Test Meeting 3', 'Third test meeting', '2024-03-05')

end