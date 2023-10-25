﻿
//using System;

//+-------------+---------+
//| Column Name | Type |
//+-------------+---------+
//| id | int |
//| name | varchar |
//| salary | int |
//| managerId | int |
//+-------------+---------+
//id is the primary key(column with unique values) for this table.
//Each row of this table indicates the ID of an employee, their name, salary, and the ID of their manager.



//Write a solution to find the employees who earn more than their managers.

//Return the result table in any order.

//The result format is in the following example.





SELECT e1.name AS employee
FROM Employee e1
JOIN Employee e2
ON e1.managerId = e2.id
WHERE e1.salary > e2.salary;