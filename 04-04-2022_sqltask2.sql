use AdventureWorks2019
go

----task 1----
select count(BusinessEntityID)
from HumanResources.Employee

select sum(BusinessEntityID)
from HumanResources.Employee

select DATEDIFF(year, '2009-01-07 00:00:00.000', '2009-01-09 00:00:00.000') AS ModifiedDate
select ModifiedDate from Person.PersonPhone


select DATEADD(year, 1, '2009-01-07 00:00:00.000') AS ModifiedDate

select convert(float, 25.65)
select convert(int, 25.65)
 
 select * from HumanResources.Employee
 select LEFT(JobTitle,BusinessEntityID) as Employee from HumanResources.Employee


 select len(JobTitle) from HumanResources.Employee


 select reverse(JobTitle) from HumanResources.Employee

---task 2---

select ModifiedDate,'$'+convert(varchar,EndOfDayRate) as PaymentAmount
from Sales.CurrencyRate

---task 3---
create table tbl_student
(
Sno int,
StuName varchar(20),
StuAge int
)
select * from tbl_student
alter table tbl_student
add MobileNO int
insert into tbl_student values(1,'Nikshi',21,233007)
create view vi_stu
as
select [Sno],[StuName],[StuAge]
from [dbo].[tbl_student]
go
select *from vi_stu
insert into tbl_student values(2,'Swetha',20,856485)

---task 4---
select * from dbo.tbl_just
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'Max','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'Max'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno
taskDel_sp 1


--task 5--
select name ,DaysTomanufacture
from Production.Product
where DaysTomanufacture in 
(select DaysTomanufacture 
from Production.Product 
where name='blade')

---task 6---
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

---task 7---
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name
