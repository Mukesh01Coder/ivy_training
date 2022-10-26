CREATE TABLE employee(emp_id INT primary key,emp_name varchar(20) NOT NULL UNIQUE,salary BIGINT)

SELECT * from employee

insert into employee values(10001,'mukesh',60000)
insert into employee values(10002,'ankit',55000)
insert into employee values(10003,'manish',50000)
insert into employee values(10004,'nisha',70000)
insert into employee values(10005,'anand',40000)
insert into employee values(10006,'sanjana',45000)
insert into employee values(10007,'poojitha',52000)
insert into employee values(10008,'raju',65000)
insert into employee values(10009,'neelam',80000)

select * from employee where salary > 50000 and salary<80000
