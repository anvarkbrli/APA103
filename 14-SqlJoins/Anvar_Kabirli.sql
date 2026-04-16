create database Company
use Company

create table Countries(
Id int primary key identity,
Name nvarchar(max)
)

create table Cities(
Id int primary key identity,
Name nvarchar(max),
CountryId int foreign key references Countries(Id)
)

create table Employees(
ID int primary key identity,
Name nvarchar(max),
Surname nvarchar(max),
Age int,
Salary money,
Position nvarchar(max),
isDeleted bit,
CityID int foreign key references Cities(Id)
)

INSERT INTO Countries (Name) VALUES 
('Azerbaijan'),
('Turkey'),
('Germany')

INSERT INTO Cities (Name, CountryId) VALUES
('Baku', 1),
('Ganja', 1),
('Istanbul', 2),
('Ankara', 2),
('Berlin', 3)

INSERT INTO Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId) VALUES
('Ali', 'Mammadov', 25, 1500, 'Developer', 0, 1),
('Nigar', 'Aliyeva', 30, 2200, 'Reseption', 0, 3),
('Rashad', 'Huseynov', 28, 2500, 'Manager', 1, 2),
('Leyla', 'Karimova', 26, 1800, 'Reseption', 0, 4),
('Kamran', 'Hasanli', 35, 3000, 'Engineer', 1, 5)

select e.Name, e.Surname , c.Name as CityName, co.Name as CountryName
from Employees e
join Cities c on e.CityId = c.Id
join Countries co on c.CountryId = co.Id

select e.Name, co.Name as CountryName
from Employees e
join Cities c on e.CityId = c.Id
join Countries co on c.CountryId = co.Id
where e.Salary > 2000

select c.Name City,co.Name Country from Cities c join Countries co on co.Id = c.CountryId

select Name, Surname, Age, Salary, Position from Employees where Position = 'Reseption'

select e.Name, e.Surname, c.Name as City,co.Name as Country
from Employees e
join Cities c on e.CityId = c.Id
join Countries co on c.CountryId = co.Id
where e.IsDeleted = 1