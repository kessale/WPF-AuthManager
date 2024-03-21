create database MVVMLoginDb
go
use MVVMLoginDb
go
CREATE TABLE User ( Id INT NOT NULL AUTO_INCREMENT, Username varchar(50) unique not null, Password nvarchar (100) not null, Namenvarchar (50) not null, LastName nvarchar (50) not null, Email nvarchar (100) unique not null);
go
insert into [User] values (NEWID(), 'admin', 'admin','RJ Code','Advance', 'rjcode@gmail.com')
insert into [User] values (NEWID(), 'jazz', 'qwerty','Jazzlyn Yarely','Sebhant', 'jazz.m@gmail.com')
insert into [User] values (NEWID(), 'keni', 'asdfg','Kenisha Aira','Montero', 'keni.m@gmail.com')
go

select *from [User]


CREATE TABLE Users (
    ID UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARYKEY,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);GO