if not exists(select 1 from dbo.[Users])
begin
	
	Insert into Users (FirstName, LastName)
	Values ('Joe', 'Johnson'),
	('John', 'Doe'),
	('Jane', 'Doe'),
	('Lucy', 'Doe')
end
