/*
Departments;
Employees;
Trainings;
EmployeeTrainings;
Computers;
EmployeeComputers;

Customers;
ProductTypes;
Products;
PaymentTypes
CustomerPaymentTypes
Orders
CustomerOrders
*/

DELETE FROM EmployeeComputers;
DELETE FROM Computers;
DELETE FROM EmployeeTrainings;
DELETE FROM Trainings;
DELETE FROM Employees;
DELETE FROM Departments;

DELETE FROM CustomerOrders;
DELETE FROM Orders;
DELETE FROM CustomerPaymentTypes;
DELETE FROM PaymentTypes;
DELETE FROM Products;
DELETE FROM ProductTypes;
DELETE FROM Customers;

DROP TABLE IF EXISTS EmployeeComputers;
DROP TABLE IF EXISTS Computers;
DROP TABLE IF EXISTS EmployeeTrainings;
DROP TABLE IF EXISTS Trainings;
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;

DROP TABLE IF EXISTS CustomerOrders;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS CustomerPaymentTypes;
DROP TABLE IF EXISTS PaymentTypes;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS ProductTypes;
DROP TABLE IF EXISTS Customers;








