create database Store
go

use Store
go

create table Tbl_Products
(
ProdID int identity(1001,1),
ProdName varchar(20),
Price money,
PurchaseDate Date,
DateofExpiry Date,
constraint pk_id primary key(prodID)
)
select * from Tbl_Products;

create table Tbl_Customers
(
CustID int identity(101,1),
CustName varchar(20),
Gender varchar(15),
DoB varchar(20),
Contactno varchar(10),
EmailID varchar(40),
City varchar(20)
)
select * from Tbl_Customers

alter table Tbl_Customers
add Constraint pk_CuID primary key(CustID)

create table Tbl_Purchases
(
BillNo int identity(2001,1),
CustomerId int,
ProductId int,
Quantity int,
Amount int,
constraint pk_Bill primary key(BillNo),
constraint fk_ref foreign key(ProductId) references Tbl_Products(ProdID),
constraint fk_ref1 foreign key(CustomerId) references Tbl_Customers(CustID)
)

select * from Tbl_Purchases;

insert into Tbl_Products values('Sweets',500,GetDate(),40+GETDATE());
insert into Tbl_Products values('Fruits',300,GetDate(),40+GetDate());
insert into Tbl_Products values('Snacks',350,GetDate(),60+GetDate());
insert into Tbl_Products values('Vegetables',400,GetDate(),10+GetDate());

select * from Tbl_Products;

insert into Tbl_Customers values('Harika','female','23-02-1999','9557486434','hari@gmail.com','Chennai');
insert into Tbl_Customers values('Nethra','female','17-12-2000','9557886434','nethu@gmail.com','Chennai');
insert into Tbl_Customers values('Ajju','male','13-02-1998','8557886434','ajju@gmail.com','Hyderabed');
insert into Tbl_Customers values('Narain','male','04-01-1999','8057886434','narain@gmail.com','Bangalore');
insert into Tbl_Customers values('Bavya','female','14-07-2001','9957886434','bavya@gmail.com','Bangalore');

select * from Tbl_Customers;
