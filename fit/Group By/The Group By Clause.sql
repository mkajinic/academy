SELECT * FROM Products;

SELECT COUNT(*) AS 'Number of Products Supplied', 
SupplierID AS 'Supplier ID' FROM Products
GROUP BY SupplierID;

--Find the most expensive product in each category (in products table)
SELECT MAX (UnitPrice), CategoryId FROM Products
GROUP BY CategoryID;

--Find the average price of products in each category
SELECT AVG (UnitPrice) As 'Average unit price', CategoryId FROM Products
GROUP BY CategoryID;


--Find the total (sum) of the unit prices for all products in each category
SELECT SUM(UnitPrice) AS 'Sum of price per category', CategoryID FROM Products
GROUP BY CategoryID;


SELECT SUM (UnitPrice) FROM PRODUCTS
WHERE CategoryID=6;

--using group by
--The HAVING clause is used to filter queries that use GROUP BY
SELECT SUM(UnitPrice), CategoryID FROM Products
WHERE UnitPrice >- 20
GROUP BY CategoryID
HAVING CategoryID IN (1,3,5,6)
ORDER BY SUM(UnitPrice) DESC;

--The the number of orders made/taken by each employee (using the orders table)
SELECT * FROM Orders;
SELECT COUNT (*) AS 'Number of orders taken', EmployeeID FROM Orders
GROUP BY EmployeeID;

--find the number of orders made by each customer
--in descending order of higest number of customer orders (using the orders table)
SELECT COUNT (*) AS 'Total orders', CustomerID FROM Orders
GROUP BY CustomerID
ORDER BY 'Total orders' DESC;

--Joins

SELECT * FROM Orders;
SELECT * FROM Customers;

--Show all orders and their corresponding customer details from customer table
SELECT * FROM Orders
INNER JOIN Customers
ON Orders.CustomerID = Customers.CustomerID;

--Show the order number, customer ID, custoemer name and employee id for all orders
SELECT OrderID, Orders.CustomerID, CompanyName, EmployeeID FROM Orders
INNER JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
INNER JOIN Employees
ON Orders.EmployeeID = Employees.EmployeeID;


SELECT OrderID, o.CustomerID, CompanyName, e.EmployeeID, e.FirstName, e.LastName 
FROM ORDERS AS o
INNER JOIN Customers AS c
ON o.CustomerID = c.CustomerID
INNER JOIN Employees AS e
ON o.EmployeeID = e.EmployeeID;

--Show the total number of orders by each customer
--and show customer company name
SELECT COUNT (*),  CustomerID FROM Orders
GROUP BY CustomerID;

--Show the total number of orers by each customer
--and show the customers company name
--and show the results in order of higest number of orders
SELECT COUNT (Customers.CustomerID) AS 'Number of orders', Orders.CustomerID 
FROM ORDERS INNER JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
GROUP BY Orders.CustomerID
ORDER BY 'Number of orders';


--Show all the orderIDs producstID and the product name for all orders
--Using order detials table and products)
SELECT OrderID, p.ProductID, p.ProductName 
FROM [Order Details]o
INNER JOIN Products p
ON o.ProductID = p.ProductID --joining the tables

--Show the name and ID of the product and number of orders for each product
--Using order detials table and products)
SELECT COUNT (*) AS 'Number of orders', ProductID 
FROM [Order Details]
GROUP BY ProductID;

SELECT COUNT (p.ProductID) AS 'Number of products', p.ProductName
FROM [Order Details] AS o
INNER JOIN Products AS p
ON o.ProductID = p.ProductID
GROUP BY p.ProductName, p.ProductName;

--Show the number of different categories each supplier supplies (from products table)
SELECT SupplierID, CategoryID, 
COUNT (*) AS [Num of categories supplied]
FROM Products
GROUP BY SupplierID, CategoryID
ORDER BY SupplierID;

SELECT 4+4 AS [Result];

SELECT Month(SYSDATETIME());

SELECT GETDATE(), SYSDATETIME();

SELECT MONTH(GETDATE()),
(MONTH(GETDATE()))/12.0;

