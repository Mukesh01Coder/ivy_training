CREATE TABLE student(
s_id INT PRIMARY KEY,
s_name varchar(20),
s_age INT,
s_sex varchar(10),
course varchar(20),
years_of_study INT
)


insert into student values(101,'mukesh',21,'M','ECE',4)
insert into student values(102,'ankit',24,'M','EEE',2)
insert into student values(103,'manish',23,'M','ECE',1)
insert into student values(104,'anand',22,'M','CS',3)
insert into student values(105,'shilpa',21,'F','ME',2)
insert into student values(106,'sanjana',22,'F','CE',3)
insert into student values(107,'nisha',24,'F','ECE',4)
insert into student values(108,'poojitha',25,'F','CS',1)

select* from student

ALTER PROCEDURE p_2 @year INT AS

 
SELECT * from student where years_of_study=@year


EXEC p_2 @year=1