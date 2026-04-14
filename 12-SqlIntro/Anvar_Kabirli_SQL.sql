
create database Company
use Company


create table Employees(

EmployeeID int,
FirstName nvarchar(max),
LastName nvarchar(max),
Email varchar(max),
PhoneNumber int,
HireDate date,
JobTitle nvarchar(max),
Salary money,
Department nvarchar(max)

)

insert into Employees(EmployeeID,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department) Values
(1,'Kamil', 'Kerimli' , 'kerimlika@gmail.com', 0703417891, '2020-10-09', 'Middle Bacnkend Developer', 2200 ,'IT' ),
(2,'Leyla', 'Hesenova' , 'agacamalev@gmail.com', 0512343782, '2021-02-11', 'HR Specialist', 1500 ,'Human resources' ),
(3,'Meqbule', 'Mehdiyeva' , 'meqbiyeva@gmail.com', 0773745673, '2015-05-16', 'Project Manager', 2000 ,'IT' ),
(4,'Cabbar', 'Huseynov' , 'frontcabbar@gmail.com', 0559122252, '2019-10-09', 'Senior Frontend Developer', 3000 ,'IT' ),
(5,'Lale', 'Quliyeva' , 'laleqululu@aztu.company.az', 0702516172, '2023-07-22', 'Marketing Manager', 1750 ,'Marketing' ),
(6, 'Nigar', 'Karimova', 'nigar.karimova@gmail.com', 0504567890, '2018-11-05', 'Accountant', 1800, 'Finance');

--Select 
select * from Employees
select * from Employees where Salary > 2000
select * from Employees where Department = 'IT';
select * from Employees order by Salary desc
select FirstName, LastName from Employees  
select * from Employees where HireDate > '2020'
select * from Employees where Email like '%company.az%'

--Aggregate Functions
select Max(Salary) as MaxSalary from Employees
select MIN(Salary) as MinSalary from Employees
select AVG(Salary) as AvgSalary from Employees
select count(EmployeeID) as EmployeeCount from Employees
select Sum(Salary) as SalarySum from Employees

--Get By
select Department, Count(*) as EmployeeCount from Employees group by Department
select Department, Avg(Salary) as AvgSalary from Employees group by Department
select Department, Max(Salary) as MaxSalary from Employees group by Department

--Update
update Employees set Salary = 2800 where EmployeeID = 1
--select * from Employees
update Employees set Salary = Salary * 1.10 where Department = 'IT'
--select * from Employees
update Employees set JobTitle = 'HR Manager' where FirstName='Leyla' and LastName = 'Hesenova'
--select * from Employees

--Delete
delete Employees where EmployeeID = 5
delete Employees where Salary < 1500
--select * from Employees

select * from Employees where FirstName like '%a%'
select * from Employees where Salary between 2000 and 2500
select * from Employees where Department in ('IT','Finance')