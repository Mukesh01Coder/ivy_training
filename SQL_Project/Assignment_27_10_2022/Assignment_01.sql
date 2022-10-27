CREATE TABLE Employees (
emp_id INT PRIMARY KEY,
emp_name varchar(20),
emp_lang varchar(20),
base_loc varchar(20)
)

insert into Employees values(1001,'Ankit','C#','Banglore')
insert into Employees values(1002,'Manish','C++','Banglore')
insert into Employees values(1003,'Anand','C#','Hyderabad')
insert into Employees values(1004,'Mukesh','C','Noida')
insert into Employees values(1005,'Soaib','Python','Dehli')

SELECT* from Employees

ALTER PROCEDURE proc_1 @lang varchar(20), @loc varchar(20)

AS

SELECT * from Employees WHERE emp_lang=@lang and base_loc=@loc
--GO;

EXEC proc_1 @lang='C#',@loc='Banglore'
