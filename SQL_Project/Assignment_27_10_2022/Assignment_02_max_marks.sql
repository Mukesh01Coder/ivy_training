CREATE TABLE student(
s_id INT PRIMARY KEY,
s_name varchar(20),
marks INT,
sub varchar(20)
)

insert into student values(101,'mukesh',80,'Maths')
insert into student values(102,'mukesh',60,'Economics')
insert into student values(103,'mukesh',55,'Commerce')
insert into student values(104,'mukesh',75,'English')
insert into student values(105,'mukesh',90,'CS')

insert into student values(106,'manish',70,'Maths')
insert into student values(107,'manish',60,'Economics')
insert into student values(108,'manish',75,'Commerce')
insert into student values(109,'manish',65,'English')
insert into student values(110,'manish',85,'CS')


insert into student values(111,'raju',95,'Maths')
insert into student values(112,'raju',50,'Economics')
insert into student values(113,'raju',70,'Commerce')
insert into student values(114,'raju',55,'English')
insert into student values(115,'raju',87,'CS')


insert into student values(116,'anand',78,'Maths')
insert into student values(117,'anand',85,'Economics')
insert into student values(118,'anand',65,'Commerce')
insert into student values(119,'anand',51,'English')
insert into student values(120,'anand',97,'CS')


insert into student values(121,'neelam',81,'Maths')
insert into student values(122,'neelam',71,'Economics')
insert into student values(123,'neelam',61,'Commerce')
insert into student values(124,'neelam',52,'English')
insert into student values(125,'neelam',93,'CS')

insert into student values(126,'raksha',98,'Maths')
insert into student values(127,'raksha',55,'Economics')
insert into student values(128,'raksha',68,'Commerce')
insert into student values(129,'raksha',79,'English')
insert into student values(130,'raksha',91,'CS')

insert into student values(131,'blinty',92,'Maths')
insert into student values(132,'blinty',60,'Economics')
insert into student values(133,'blinty',68,'Commerce')
insert into student values(134,'blinty',82,'English')
insert into student values(135,'blinty',91,'CS')

insert into student values(136,'akash',87,'Maths')
insert into student values(137,'akash',75,'Economics')
insert into student values(138,'akash',62,'Commerce')
insert into student values(139,'akash',65,'English')
insert into student values(140,'akash',95,'CS')


insert into student values(141,'sweta',75,'Maths')
insert into student values(142,'sweta',70,'Economics')
insert into student values(143,'sweta',62,'Commerce')
insert into student values(144,'sweta',65,'English')
insert into student values(145,'sweta',80,'CS')

insert into student values(146,'ravindra',85,'Maths')
insert into student values(147,'ravindra',77,'Economics')
insert into student values(148,'ravindra',58,'Commerce')
insert into student values(149,'ravindra',68,'English')
insert into student values(150,'ravindra',92,'CS')


select* from student


ALTER PROCEDURE p_3 AS

DECLARE @result table (name varchar(20),max_marks INT)

insert into @result select s_name,SUM(marks) AS marks from student group by s_name order by marks DESC
SELECT * from @result

EXEC p_3
