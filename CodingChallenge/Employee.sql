create database Employee;
go

create schema EmployeeDB;
go

create table Employee
(
   EmployeeID int not null identity primary key
   FirstName nvarchar(50) not null, --char, varchar, nchar, nvarchar, nvarcharmax
   LastName nvarchar(50) not null,
   SSN int not null,
   DeptID int not null identity foreign key
)
go

--simple insert 
insert into Employee
values('Him', 'Brom', '123212135', '352')
values('Him', 'Brom', '123212135', '352')
values('Him', 'Brom', '123212135', '352')
go

UPDATE Employee   
SET { FirstName = { 'Tina' }, LastName = { 'Smith'} 
FROM Employee 
go



create table Department
(
   DepartmentId int not null identity primary key,
   Name nvarchar(50) not null, --char, varchar, nchar, nvarchar, nvarcharmax
   Location nvarchar(50) not null-- we don't want the primary key to be null 
   -- identity() takes seed-start and step--increment
   -- primary key means indexing, indexing means you are setting a unique identifier
   -- if you index every column there will be a larger set of meta data

   -- we don't want the primary key to be null 
   -- identity() takes seed-start and step--increment
   -- primary key means indexing, indexing means you are setting a unique identifier
   -- if you index every column there will be a larger set of meta data

)
go

alter table Department
(
    ALTER TABLE table_name
    ADD Marketing varchar (50);
)

--list all Marketing employees
SELECT * EmployeeID
from Department
Where Name = 'Marketing'

--report total salary of Marketing
SELECT SUM(Salary)
FROM EmpDetails
[WHERE Name = 'Marketing'];

--report total employees by department
SELECT SUM(EmployeeID)
From Employee
Order BY DeptID

--increase salary of Tina Smith to 90,000
UPDATE Employee   
SET Salary = { 'Tina' }, LastName = { 'Smith'} 
FROM Employee
WHERE FirstName = {'Tina'} AND LastName = {'Smith'} 
go

--simple insert 
insert into Employee
values('jas', 'Broming', '12385435', '3652')
values('Had', 'tud', '12323225', '34')
values('Hackman', 'fan', '123212135', '866')
go

create table EmpDetails
(
   EmpID int not null identity primary key
   EmployeeID int not null identity foreign key,
   Salary int not null,
   AddressOne int not null,
   AddressTwo int not null,
   City nvarchar(50) not null,
   State nvarchar(50) not null,
   Country nvarchar(50) not null
   -- we don't want the primary key to be null 
   -- identity() takes seed-start and step--increment
   -- primary key means indexing, indexing means you are setting a unique identifier
   -- if you index every column there will be a larger set of meta data

)
go

--simple insert 
insert into EmpDetails
values('hoj', 'Brdom', '123212135', '322')
values('jon', 'Browm', '123223135', '462')
values('mat', 'Brdsom', '123212135', '952')
go