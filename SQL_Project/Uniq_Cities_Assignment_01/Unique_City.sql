CREATE TABLE Emp (
    emp_id int NOT NULL,
    emp_name varchar(255) NOT NULL,
    emp_city varchar(255),
    emp_salary int,
    UNIQUE (emp_city)
);

insert into Emp values(1001,'Nisha','Banglore',60000)
select * from Emp
insert into Emp values(1002,'Nisha','Patna',65000)
insert into Emp values(1004,'Poojitha','Hyderabad',60000)
insert into Emp values(1005,'Blinty','Kerela',60000)
insert into Emp values(1003,'Archana','Patna',55000)

