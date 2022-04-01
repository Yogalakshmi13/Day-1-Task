use AdventureWorks2019
go

--task1 firstname,lastname
select FirstName, LastName
from person.person
where Title is not null

--task2 firstname,lastname like'a'
select Firstname,Lastname 
from person.person
where Firstname like '%a%' or Lastname like '%a%'

---task3 currencycode without join
select sales.countryregioncurrency.currencycode,name 
from sales.currency, sales.countryregioncurrency 

--task4 copy table
 select * into HR_dept from HumanResources.Department
 
 select * from HR_dept

---task5 create table 
create table stuDetails
(
SNo int identity(1006,1),
Fullname varchar(20),
Gender char(1),
Age int,
Emailid varchar(20)
)
select * from stuDetails

insert stuDetails values('Nikshi','F',21,'niki@gmail')
insert stuDetails values('Swetha','F',21,'swetha@gmail')
insert stuDetails values('Gloriya','F',21,'glori@gmail')
insert stuDetails values('Jenitha','F',20,'jeni@gmail')
insert stuDetails values('Devi','F',21,'devi@gmail')
insert stuDetails values('Nethra','F',13,'nethra@gmail')
insert stuDetails values('Ajju','M',5,'ajju@gmail')
insert stuDetails values('Narain','M',10,'narain@gmail')
insert stuDetails values('Dhruvan','M',4,'dhru@gmail')
insert stuDetails values('Bavya','F',6,'bavya@gmail')

select * from stuDetails

--task6 inner join
select dhis.BusinessEntityID, addresstypeid 
from HumanResources.EmployeeDepartmenthistory dhis
join person.BusinessEntityAddress per
on dhis.BusinessEntityID = per.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=dhis.DepartmentID


--task7 distinct values by groupname
select distinct groupname
from HumanResources.Department

--task8 sum of listprice and standardcost
select pro.standardcost, sum(listprice)
sum1, sum(pro.standardcost+listprice)
sum2
from Production.product pro
join Production.ProductCostHistory pcost
on pro.ProductID=pcost.ProductID
group by pro.StandardCost

--task9 datediff()

select DATEDIFF(YY,StartDate,EndDate) as yearonrole

from HumanResources.EmployeeDepartmentHistory

---task10 filter the data
select sum(SalesQuota)
from Sales.SalesPersonQuotaHistory
where SalesQuota>5000 and SalesQuota<100000
group by SalesQuota

--task11 max(rate)
select Max(TaxRate) maximumtaxrate
from Sales.SalesTaxRate

--task12 joins
select emp.BusinessEntityID, dept.DepartmentID,ShiftID
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory hdhis
on emp.BusinessEntityID= hdhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=dept.DepartmentID
select birthdate,getdate() as currentdate,
DATEDIFF(YY,birthdate,GETDATE()) as Age
from HumanResources.Employee

--task13 view
create view employee
as 
select birthdate,getdate() as currentdate,
DATEDIFF(YY,birthdate,GETDATE()) as Age
from HumanResources.Employee
go 
select * from employee


--task14 count
Select count(*) as Noofrows
from [HumanResources].[Employee],[HumanResources].[Department],
[HumanResources].[EmployeeDepartmentHistory],
[HumanResources].[EmployeePayHistory],
[HumanResources].[Shift]

--task15 max(rate)
select max(rate) as Maxsalary,name
from HumanResources.EmployeePayHistory hpay
join HumanResources.EmployeeDepartmentHistory hdhis
on hpay.BusinessEntityID=hdhis.BusinessEntityID
join HumanResources.Department hdept
on hdept.DepartmentID=hdhis.DepartmentID
Group By name

--task16 Title not null
select FirstName,MiddleName,Title,
addr.BusinessEntityID
from Person.BusinessEntityAddress addr
left outer join Person.Person pers
on pers.BusinessEntityID=addr.BusinessEntityID
where Title is not null

--task17 product
select ProductID, LocationID,Shelf
from Production.ProductInventory 
where ProductID>300 and ProductID<=350
and LocationID=50 

--task18 productinventory
select pl.LocationID,shelf,Name
from [Production].[ProductInventory] pro
join [Production].[Location] pl
on pro.LocationID=pl.LocationID

--task19 stateprovince
Select AddressID, AddressLine1, AddressLine2,
paddr.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince pstat
join Person.Address paddr
on pstat.StateProvinceID=paddr.StateProvinceID

--task20 toal and tax
select sum(subtotal), sum(taxamt)
from Sales.CountryRegionCurrency curr
join sales.SalesTerritory sal
on curr.CountryRegionCode=sal.CountryRegionCode
join Sales.SalesOrderHeader soh
on sal.TerritoryID=soh.TerritoryID
group by sal.TerritoryID