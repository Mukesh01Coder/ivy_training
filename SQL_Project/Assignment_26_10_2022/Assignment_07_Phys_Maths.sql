CREATE TABLE student(
s_id INT primary key,
s_name varchar(20),
s_course varchar(20)
)

insert into student values(101,'mukesh','Maths')
insert into student values(102,'mukesh','Phys')
insert into student values(103,'mukesh','chem')

insert into student values(104,'manish','Bio')
insert into student values(105,'manish','Ag')
insert into student values(106,'manish','chem')

insert into student values(107,'laveena','Maths')
insert into student values(108,'laveena','Bio')
insert into student values(109,'laveena','chem')

insert into student values(110,'puja','Bio')
insert into student values(111,'puja','Phys')
insert into student values(112,'puja','chem')

select * from student

SELECT s_name
FROM student
WHERE s_course  not in ('Maths','Phys')
GROUP BY s_name
HAVING COUNT(distinct s_course) >= 2