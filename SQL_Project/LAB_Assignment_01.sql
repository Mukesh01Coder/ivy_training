CREATE TABLE customers (cus_id INT,name varchar(20), address varchar(30),tel_no BIGINT,email varchar(30) )

insert into customers values(101,'shyam','jaipur road no 2',9854328921,'shyam120@gmail.com')
insert into customers values(102,'ramu','jaipur road no 7',9754328911,'ramu321@gmail.com')
insert into customers values(103,'neelam','jaipur road no 10',9954328961,'neelam901@gmail.com')
insert into customers values(104,'raksha','jaipur road no 5',9654328931,'raksha543@gmail.com')
insert into customers values(105,'nisha','jaipur road no 9',9054328951,'nisha678@gmail.com')

SELECT * FROM customers

CREATE TABLE ITEMS (item_id INT, name varchar(20),price BIGINT)

insert into ITEMS values(1001,'TV',15000)
insert into ITEMS values(1002,'Mobile',20000)
insert into ITEMS values(1003,'Iphone',100000)
insert into ITEMS values(1004,'Laptop',150000)
insert into ITEMS values(1005,'Teplate',40000)

SELECT * FROM ITEMS

-- here cus_id is working as a foreign key, it is linking customer table and orders table
CREATE TABLE ORDERS (order_id INT, cus_id INT,date_time datetime)

insert into ORDERS values(10001,101,'2022-10-25 05:45:52')
insert into ORDERS values(10002,102,'2022-10-21 08:00:00')
insert into ORDERS values(10003,103,'2022-10-26 03:00:00')
insert into ORDERS values(10004,104,'2022-10-29 01:45:30')
insert into ORDERS values(10005,105,'2022-10-30 06:15:12')

SELECT * FROM ORDERS


-- here order_id,item_id is working as a foreign key and it is linking order table,item table and order_item table 
CREATE TABLE ORDER_ITEM (ord_item_id INT, order_id INT,item_id INT,product_quantity BIGINT)

insert into ORDER_ITEM values(1221,10001,1001,1)
insert into ORDER_ITEM values(1222,10002,1002,2)
insert into ORDER_ITEM values(1223,10003,1003,1)
insert into ORDER_ITEM values(1224,10004,1004,2)
insert into ORDER_ITEM values(1225,10005,1005,3)


SELECT* FROM ORDER_ITEM


-- query
-- Print customer name,Product Quantity,datetime,price , he is buying a LAPTOP OR IPHONE 

SELECT customers.name AS cus_name,
ITEMS.name as Item_name ,
price as price,
product_quantity as quantity,
ORDERS.date_time AS date_time 
from customers
INNER JOIN ORDERS
ON customers.cus_id = ORDERS.cus_id
INNER JOIN ORDER_ITEM 
ON ORDER_ITEM.order_id = ORDERS.order_id
INNER JOIN ITEMS
ON ITEMS.item_id = ORDER_ITEM.item_id



