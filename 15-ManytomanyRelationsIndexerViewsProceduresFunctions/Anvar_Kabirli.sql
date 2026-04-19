create database CompanyMM
use CompanyMM

create table Employees(
EmployeeID int primary key identity,
FirstName nvarchar(20),
LastName nvarchar(30),
BirthDate date, 
Email varchar(50) unique
)

create table Projects(
ProjectID int primary key identity,
ProjectName nvarchar(max) not null,
StartDate date not null,
EndDate date not null,
check (StartDate <= EndDate)
)

create table EmployeeProjects(
EmployeeID int foreign key references Employees(EmployeeID),
ProjectID int foreign key references Projects(ProjectID),
AssignedDate date check(AssignedDate < Getdate())
)

insert into Employees(FirstName, LastName, BirthDate, Email) values
('Mehemmed', 'Eyvazov', '1990-03-15', 'mehemmedayvazov@gmail.com'),
('Gulbahar', 'Ezizova', '2000-05-12', 'gulspring133@gmail.com'),
('Vugar', 'Aliyev', '1998-11-05', 'vugar.aliyev@gmail.com'),
('Nazli', 'Eyvazova', '1995-09-17', 'eyvazoffanazli@gmail.com'),
('Kazim', 'Cemilov', '2004-03-30', 'kazimcmlov185@gmail.com')

insert into Projects(ProjectName,StartDate,EndDate) values
('E-Commerce Website', '2015-01-07', '2017-06-01'),
('Mobile App', '2024-07-18', '2026-01-15'),
('CRM System', '2023-03-01', '2025-09-01'),
('Banking System', '2017-05-25', '2018-12-01'),
('AI Chatbot', '2024-09-15', '2026-02-18')

insert into EmployeeProjects(EmployeeID,ProjectID,AssignedDate) values
(1, 1, '2015-02-01'),
(2, 1, '2015-03-10'),
(3, 1, '2016-01-15'),

(1, 2, '2024-08-01'),
(2, 2, '2024-08-05'),
(4, 2, '2024-09-01'),
(5, 2, '2024-10-10'),

(1, 3, '2023-04-01'),
(3, 3, '2023-05-01'),

(4, 4, '2017-06-15'),

(2, 5, '2024-10-01'),
(5, 5, '2024-11-01')

select * from Employees
select * from Projects

select e.FirstName,e.LastName, p.ProjectName from Employees as e
join EmployeeProjects as ep
on e.EmployeeID = ep.EmployeeID
join Projects as p
on p.ProjectID = ep.ProjectID

select p.ProjectName, COUNT(*) as EmployeeCount from Projects as p
join EmployeeProjects as ep
on p.ProjectID = ep.ProjectID
group by ProjectName

select e.FirstName,e.LastName, Count(ep.ProjectID) as ProjectCount from Employees as e
join EmployeeProjects as ep
on e.EmployeeID = ep.EmployeeID
group by e.FirstName, e.LastName, e.EmployeeID
having  COUNT(ep.ProjectID) > 2

create view EmployeeProjectView as 
select e.EmployeeID, e.FirstName +' ' +e.LastName as FullName, p.ProjectID, p.ProjectName, ep.AssignedDate from Employees as e
join EmployeeProjects as ep
on e.EmployeeID = ep.EmployeeID
join Projects as p on ep.ProjectID = p.ProjectID

select ProjectName from EmployeeProjectView where EmployeeID = 3

create procedure sp_AssignEmployeeToProject
    @empId int,
    @projId int
as
begin
    if not exists (
        select 1
        from EmployeeProjects
        where EmployeeID = @empId and ProjectID = @projId
    )
    begin
        insert into EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
        values (@empId, @projId, getdate())
    end
end
go

create function fn_GetProjectCount (@empId int)
returns int
as
begin

    declare @ProjectCount int
    select @ProjectCount = count(ProjectID)
    from EmployeeProjects
    where EmployeeID = @empId
    return @ProjectCount

end
go

select dbo.fn_GetProjectCount(1) as ProjectCount

exec sp_AssignEmployeeToProject @empId = 4, @projId = 5

select *
from EmployeeProjects
where EmployeeID = 4 and ProjectID = 5

delete from EmployeeProjects
where EmployeeID = 3

select *
from EmployeeProjects
where EmployeeID = 3