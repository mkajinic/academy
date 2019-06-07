
/* 
1) Select the sum of the monthly salaries for all 
clerks (JOB_ID) who work in the shipping department
*/
SELECT SUM(ANNUAL_SALARY/12) FROM Employees
WHERE Job_ID LIKE '%CLERK%' 
AND Department_No = 70;

--Using subqueries
SELECT SUM (ANNUAL_SALARY/12) FROM Employees
WHERE Job_ID IN (SELECT Job_ID FROM Jobs WHERE Job_Title LIKE '%clerk%')
AND 
Department_No = (SELECT Department_No FROM Departments WHERE Department_Name = 'SHIPPING')

--Using joins
SELECT SUM (e.Annual_Salary/12) FROM Employees AS e
INNER JOIN Jobs AS J
ON e.Job_ID = J.Job_ID
INNER JOIN Departments AS d
ON E.Department_No = D.Department_No
WHERE D.Department_Name = 'SHIPPING'
AND J.Job_Title LIKE '%CLERK%'

/*
2) List the last name, first name and employee 
number of all employees that have a last name 
starting with M.
*/
SELECT  Employee_No, First_Name, Last_Name FROM Employees
WHERE Last_Name LIKE 'M%'
ORDER BY Last_Name ASC;

/*
3) List the department number, last name, first name 
and phone number of all sales representatives who 
were hired on or after 24 Mar 1998 sorted in 
ascending order of last name.
*/
SELECT Department_No, Last_Name, First_Name, Phone_Number
FROM Employees
WHERE Job_ID LIKE '%SA_REP%'
AND Hire_Date >= '24 MAR 1998'
ORDER BY Last_Name ASC


/*
4) List all the data for all jobs where the 
minimum salary is less than or equal to 4500 
sorted in descending order of the minimum salary.
*/
SELECT * FROM Jobs
WHERE Min_Salary <= '4500'
ORDER BY Min_Salary DESC;


/*
5) Which jobs are found in the Marketing 
and Accounting departments? 
*/
SELECT Job_Title FROM Jobs
WHERE Job_ID IN 
	(SELECT Job_ID 
	 FROM Employees 
	 WHERE Department_No IN (
						SELECT Department_No 
						FROM Departments 
						WHERE Department_Name = 'MARKETING' 
						OR Department_Name = 'ACCOUNTING' )
	)
SELECT Job_Title FROM Jobs
WHERE Job_ID IN (SELECT Job_ID FROM Employees
WHERE  Department_No IN (SELECT Department_No FROM Departments
WHERE Department_Name IN ('ACCOUNTING', 'MARKETING')))


--SubQuery way
SELECT DISTINCT j.Job_Title FROM Jobs AS j
INNER JOIN Employees AS e
ON j.Job_ID = e.Job_ID
INNER JOIN Departments AS d
ON d.Department_No = e.Department_No
WHERE d.Department_Name IN ('ACCOUNTING', 'MARKETING')


/*
6) List the department name, location, last name 
and salary of employees who work in location 
1700 sorted in ascending order of department name.
*/
/*
SELECT Department_Name, Location_ID FROM Departments
WHERE Last_Name IN (SELECT Last_Name FROM Employees 
WHERE Annual_Salary IN (SELECT Annual_Salary FROM Employees ))
*/


/*
7) List the last name and first name for 
all employees who were hired in the months 
of June or August (for all years) sorted 
in ascending order of last name.
*/
/*
SELECT First_Name, Last_Name FROM Employees
WHERE Hire_Date LIKE 
ORDER BY Last_Name ASC
*/

/*
8) Show the average salary for employees 
for one year (rounded to 2 decimal places).
*/



/*
9) Show the total monthly salaries figure 
(0 decimal places) for all employees in
departments 80 and 60.
*/



/*
10) List the last name, first name and employee 
number of all programmers who were hired on or 
before 21 May 1991 sorted in ascending order 
of last name.
*/



/*
11) List the department number, last name 
and salary of all employees who were 
hired between 16/09/87 and 12/05/96 
sorted in ascending order of last name 
within department number.
*/



/*
12) List all the data for all jobs where the 
maximum salary is greater than 15000 sorted 
in descending order of the maximum salary.
*/



/*
13) List the last name, first name, 
job id and commission of employees who 
earn commission sorted in ascending 
order of first name within last name.
*/



/*
14) Which jobs are found in the IT and 
Sales departments?
*/
SELECT Job_Title FROM Jobs
WHERE Job_ID IN 
	(SELECT Job_ID 
	 FROM Employees 
	 WHERE Department_No IN (
						SELECT Department_No 
						FROM Departments 
						WHERE Department_Name = 'SALES' 
						OR Department_Name = 'IT' )
	)

/*
15) List the last name of all employees in 
departments 50 and 90 together with their 
monthly salaries (rounded to 2 decimal places), 
sorted in ascending order of last name.
*/
SELECT Last_Name FROM Employees
WHERE Annual_Salary/12 IN 
	(SELECT Job_ID 
	 FROM Employees 
	 WHERE Department_No IN (
						SELECT Department_No 
						FROM Departments 
						WHERE Department_Name = 'SALES' 
						OR Department_Name = 'IT' )
	)


/*
16) Show the total salaries figure for 
one month displayed with no decimal places.
*/

/*
17) Show the total number of employees.
*/





