use mukesh
drop table sales_detail
create TABLE sales_detail 
(s_id INT identity PRIMARY KEY,
s_name varchar(20),
amount BIGINT,
city varchar(20),
email_address  varchar(20) UNIQUE
)
--delete from sales_detail


insert into sales_detail values ('mukesh',2000,'Delhi','mukesh@gmail.com')
insert into sales_detail values ('manish',4000,'Delhi','manish@gmail.co')
insert into sales_detail values ('anand',3000,'Delhi','anand@gmail.co')
insert into sales_detail values ('ankit',5000,'Delhi','ankit@gmail.co')
insert into sales_detail values ('sanjana',6000,'Delhi','sanjna@gmail.co')

insert into sales_detail values ('nisha',1000,'Bihar','nisha@gmail.co')
insert into sales_detail values ('poojitha',2000,'Bihar','poojitha@gmail.co')
insert into sales_detail values ('shilpa',3000,'Bihar','shilpa@gmail.co')
insert into sales_detail values ('kishor',4000,'Bihar','kishor@gmail.co')
insert into sales_detail values ('ramu',2000,'Delhi','mukesh@gmail.com')

insert into sales_detail values ('raju',10000,'UP','raju@gmail.com')


SELECT * FROM sales_detail


create or alter procedure create_sales(@p_s_name varchar(max), @p_s_amount BigInt, @p_city varchar(max),@email varchar(max))
as
insert into sales_detail values(@p_s_name,@p_s_amount,@p_city,@email)
--exec create_sales 'sanya',6000,'Delhi' ' '



--create or alter procedure create_sale as
--select s_name,amount,city from sales_detail where amount <=5000
--EXEC create_sale