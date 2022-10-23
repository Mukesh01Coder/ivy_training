CREATE TABLE employees (emp_id int,emp_name nvarchar(20),emp_city nvarchar(20))
INSERT INTO employees VALUES (1,'mukesh','jaipur')
SELECT *  FROM employees
INSERT INTO employees VALUES (2,'sanjana','Bihar')
INSERT INTO employees VALUES (3,'Ankit','Jharkhand')
INSERT INTO employees VALUES (4,'nisha','Banglore')
INSERT INTO employees VALUES (5,'manish','Nepal')

INSERT INTO employees VALUES (6,'raju','Jharkhand')
INSERT INTO employees VALUES (7,'blinty','Banglore')
INSERT INTO employees VALUES (8,'mahima','Nepal')
INSERT INTO employees VALUES (9,'Anand','jaipur')
INSERT INTO employees VALUES (10,'mukesh','jaipur')

SELECT  DISTINCT emp_city from employees