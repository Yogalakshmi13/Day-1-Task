use AdventureWorks2019
go


select getdate()
create database Register

use Register
go

create table form
(
Sno int,
Firstname varchar(20),
Lastname varchar(20),
Age int constraint chk_Age check(Age>=18),
Emailid varchar(40),
Contactno varchar(10),
Addres varchar(20),
Gender varchar(1),
Collegename varchar(30),
Degree varchar(10),
Branch varchar(10),
SSLCboard varchar(10),
SSLCpercentage int,
HSCboard varchar(10),
HSCpercentage int,
)

select * from form

insert form values(1,'Nikshidha','Samadhan',20,'nikshi@gmail','8393282398','abc colony','F','Panimalar','B.Tech','IT','Stateboard',88,'Stateboard',78)
insert form values(2,'Swetha','Boopalan',19,'swe@gmail','9887892398','xxx colony','F','Panimalar','BE','CSE','Stateboard',86,'Stateboard',75)
insert form values(3,'Gloriya','Seelan',19,'glori@gmail','7393282398','yyy colony','F','Stjoseph','B.Tech','IT','Stateboard',77,'Stateboard',74)
insert form values(4,'Jenitha','Dsouza',17,'jeni@gmail','8393287398','zzz colony','F','Satyabama','BE','ECE','CBSE',68,'Stateboard',76)
insert form values(5,'Devi','M',20,'devi@gmail','8393287488','aaa colony','F','Panimalar','B.Tech','IT','CBSE',78,'Stateboard',77)

select* from form