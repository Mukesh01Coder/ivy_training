use mukesh

CREATE TABLE student(
s_id INT PRIMARY KEY,
s_name varchar(20),
Course_name varchar(50),
marks INT
)

insert into student values(1001,'mukesh','Phys',80)
insert into student values(1002,'mukesh','Chem',70)
insert into student values(1004,'mukesh','Maths',60)
insert into student values(1005,'mukesh','Eng',55)


insert into student values(1006,'manish','Phys',60)
insert into student values(1007,'manish','Chem',80)
insert into student values(1008,'manish','Maths',90)
insert into student values(1009,'manish','Eng',65)

insert into student values(1010,'nisha','Phys',78)
insert into student values(1011,'nisha','Chem',85)
insert into student values(1012,'nisha','Maths',90)
insert into student values(1013,'nisha','Eng',60)

insert into student values(1014,'sanjana','Phys',68)
insert into student values(1015,'sanjana','Chem',75)
insert into student values(1016,'sanjana','Maths',95)
insert into student values(1017,'sanjana','Eng',65)

select* from student
--drop table student


CREATE OR ALTER PROCEDURE p1 @t_mark INT AS 
BEGIN
SELECT s_name, SUM(marks) AS s_total from student group by s_name having  SUM(marks) <@t_mark
END

select* from student

CREATE OR ALTER PROCEDURE p2 @d_s_name varchar(20) AS
BEGIN
DECLARE @total_marks AS INT
SELECT  @total_marks= SUM(marks)  from student group by s_name having s_name = @d_s_name 


--select SUM(marks) from student group by s_name  having s_name = 'sanjana'

EXEC p1 @total_marks
END

--EXEC p1 303 
--EXEC p2 'sanjana'
