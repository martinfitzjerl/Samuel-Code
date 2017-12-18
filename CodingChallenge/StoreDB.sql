create database StoreDB;
go

create schema Store;
go

create table Products
(
   ProductsID int not null identity primary key
   Name nvarchar(50) not null, --char, varchar, nchar, nvarchar, nvarcharmax
   Price char(50) not null-- we don't want the primary key to be null 
   -- identity() takes seed-start and step--increment
   -- primary key means indexing, indexing means you are setting a unique identifier
   -- if you index every column there will be a larger set of meta data

)

create table Orders
(
   OrderID int not null identity primary key
   ProductID int not null identity foreign key,
   CustomerID int not null identity foreign key
   -- we don't want the primary key to be null 
   -- identity() takes seed-start and step--increment
   -- primary key means indexing, indexing means you are setting a unique identifier
   -- if you index every column there will be a larger set of meta data

)


create table Customers
(
   CustomerID int not null identity primary key
   Firstname nvarchar (50) not null,
   Lastname nvarchar (50) not null,
   CardNumber int (50) not null
   -- we don't want the primary key to be null 
   -- identity() takes seed-start and step--increment
   -- primary key means indexing, indexing means you are setting a unique identifier
   -- if you index every column there will be a larger set of meta data

)