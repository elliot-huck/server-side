/*
Departments;
Employees;
Trainings;
EmployeeTrainings;
Computers;
EmployeeComputers;
*/

INSERT INTO Departments
VALUES
(
	null, 
	"Marketing", 
	300.00
);
	
INSERT INTO Departments
VALUES
(
	null, 
	"Customer Service", 
	800.00
);

INSERT INTO Departments
VALUES
(
	null, 
	"Information Technology", 
	1000.00
);
	
INSERT INTO Departments
VALUES
(
	null, 
	"Human Resources", 
	100.00
);

INSERT INTO Employees
VALUES
(
	null,
	"Alice",
	"Anderson",
	"2018-09-06 12:00:00.000",
	15.00,
	0,
	0,
	1
);

INSERT INTO Employees
VALUES
(
	null,
	"Bob",
	"Brown",
	"2018-09-06 12:00:00.000",
	13.00,
	0,
	0,
	2
);

INSERT INTO Employees
VALUES
(
	null,
	"Carol",
	"Cook",
	"2018-09-06 12:00:00.000",
	40000,
	1,
	0,
	3
);

INSERT INTO Employees
VALUES
(
	null,
	"Dave",
	"Davidson",
	"2018-09-06 12:00:00.000",
	11.00,
	0,
	0,
	4
);

INSERT INTO Employees
VALUES
(
	null,
	"Emily",
	"Evans",
	"2018-09-06 08:00:00.000",
	50000,
	1,
	1,
	1
);

INSERT INTO Employees
VALUES
(
	null,
	"Fred",
	"Fitzgerald",
	"2018-09-06 08:00:00.000",
	30000,
	1,
	1,
	2
);

INSERT INTO Employees
VALUES
(
	null,
	"Gina",
	"Gregson",
	"2018-09-06 08:00:00.000",
	60000,
	1,
	1,
	3
);

INSERT INTO Employees
VALUES
(
	null,
	"Henry",
	"Houdini",
	"2018-09-06 08:00:00.000",
	70000,
	1,
	1,
	4
);


INSERT INTO Trainings
VALUES
(
	null,
	"Basic Training",
	"2018-09-10 08:00:00.000",
	"2018-09-14 08:00:00.000",
	10
);

INSERT INTO Trainings
VALUES
(
	null,
	"Intermediate Training",
	"2018-09-17 08:00:00.000",
	"2018-09-21 08:00:00.000",
	10
);

INSERT INTO Trainings
VALUES
(
	null,
	"Advanced Training",
	"2018-09-24 08:00:00.000",
	"2018-09-28 08:00:00.000",
	10
);

INSERT INTO EmployeeTrainings
VALUES
(
	null,
	1,
	3
);

INSERT INTO EmployeeTrainings
VALUES
(
	null,
	1,
	2
);

INSERT INTO EmployeeTrainings
VALUES
(
	null,
	2,
	1
);

INSERT INTO EmployeeTrainings
VALUES
(
	null,
	4,
	3
);

INSERT INTO EmployeeTrainings
VALUES
(
	null,
	5,
	1
);

INSERT INTO EmployeeTrainings
VALUES
(
	null,
	5,
	2
);

INSERT INTO Computers
VALUES
(
	null,
	"HP Laptop",
	"2018-08-27 08:00:00.000",
	"2018-09-04 08:00:00.000",
	0
);

INSERT INTO Computers
VALUES
(
	null,
	"Dell Laptop",
	"2018-08-27 08:00:00.000",
	null,
	1
);

INSERT INTO Computers
VALUES
(
	null,
	"Apple Laptop",
	"2018-08-27 08:00:00.000",
	null,
	0
);

INSERT INTO Computers
VALUES
(
	null,
	"Inspiron Laptop",
	"2018-08-27 08:00:00.000",
	null,
	1
);

INSERT INTO Computers
VALUES
(
	null,
	"Dell Laptop",
	"2018-08-27 08:00:00.000",
	null,
	1
);

INSERT INTO Computers
VALUES
(
	null,
	"Apple Laptop",
	"2018-08-27 08:00:00.000",
	null,
	1
);

INSERT INTO EmployeeComputers
VALUES
(
	null,
	"2018-09-02 12:00:00.000",
	"2018-09-03 12:00:00.000",
	1,
	1	
);

INSERT INTO EmployeeComputers
VALUES
(
	null,
	"2018-09-03 13:00:00.000",
	"2018-09-04 07:00:00.000",
	2,
	1	
);

INSERT INTO EmployeeComputers
VALUES
(
	null,
	"2018-09-03 13:00:00.000",
	null,
	3,
	5	
);

INSERT INTO EmployeeComputers
VALUES
(
	null,
	"2018-09-03 13:00:00.000",
	"2018-09-06 13:00:00.000",
	4,
	3	
);

INSERT INTO EmployeeComputers
VALUES
(
	null,
	"2018-09-07 15:00:00.000",
	null,
	6,
	3	
);


/*
Customers;
ProductTypes;
Products;
PaymentTypes;
CustomerPaymentTypes;
Orders;
CustomerOrders;
*/

INSERT INTO Customers
VALUES
(
	null,
	"Mike",
	"Malone",
	"2018-09-01 12:00:00.000",
	"2018-09-06 12:00:00.000",
	null
);

INSERT INTO Customers
VALUES
(
	null,
	"Nancy",
	"Nichols",
	"2018-09-01 12:00:00.000",
	"2018-09-04 12:00:00.000",
	null
);

INSERT INTO Customers
VALUES
(
	null,
	"Oliver",
	"Orwell",
	"2018-09-02 12:00:00.000",
	"2018-09-03 12:00:00.000",
	null
);

INSERT INTO Customers
VALUES
(
	null,
	"Peggy",
	"Peterson",
	"2018-09-03 12:00:00.000",
	"2018-09-06 12:00:00.000",
	null
);

