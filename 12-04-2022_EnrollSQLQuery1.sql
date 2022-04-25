use Details
go

select * from enroll
go

create procedure sp_InstTest
@Sno int, @Fname varchar(20), @Lname varchar(20), @Emailid varchar(40)
as
insert enroll values(@Sno,@Fname,@Lname,@Emailid)
sp_InstTest 1011,'Harika','Maha','Harika@gmail'