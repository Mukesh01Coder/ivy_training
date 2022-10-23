CREATE TABLE collage1_students (c1_name varchar(20),age1 INT,subjects1 varchar(20))
insert into collage1_students values ('Nisha',24,'Biology')
insert into collage1_students values ('Sanjana',22,'Mathamatics')
insert into collage1_students values ('Poojitha',23,'Arts')
insert into collage1_students values ('Shilpa',24,'Mathamatics')
insert into collage1_students values ('Blinty',22,'Biology')
insert into collage1_students values ('Archana',20,'Mathamatics')


CREATE TABLE collage2_students (c2_name varchar(20),age2 INT,subjects2 varchar(20))



insert into collage2_students values ('Rakesh',19,'Mathamatics')
insert into collage2_students values ('Rohit',23,'Commerce')
insert into collage2_students values ('Manish',24,'Biology')
insert into collage2_students values ('Ankit',22,'Mathamatics')
insert into collage2_students values ('Anand',23,'Arts')
insert into collage2_students values ('Rajesh',24,'Mathamatics')
insert into collage2_students values ('Ravi',23,'Biology')
insert into collage2_students values ('Ramesh',21,'Mathamatics')


SELECT * from collage1_students
SELECT * from collage2_students

select collage1_students.age1 as age,collage1_students.c1_name as FullName,collage1_students.subjects1 as sub from collage1_students where collage1_students.subjects1='Mathamatics' and collage1_students.age1>21
Union
select collage2_students.age2 as age,collage2_students.c2_name as FullName,collage2_students.subjects2 as sub  from collage2_students where collage2_students.subjects2='Mathamatics' and collage2_students.age2>21
