create database [EmployeeSystem]

use EmployeeSystem

create table UsersManagers(
UsersManager_ID int identity (1,1) primary key,
UsersManager_Name nvarchar(30),
UsersManager_Pass nvarchar(30)
)
insert into UsersManagers values ('omar','1234'),
('omar2','4321')
select * from UsersManagers
create table UsersEmployees(
UsersEmployee_ID int identity (1,1) primary key,
UsersEmployee_Name nvarchar(30),
UsersEmployee_Pass nvarchar(30)
)
insert into UsersEmployees values ('mohamed','1234'),
('Amr','4321')
select * from UsersEmployees

create table EmployeesTasks(
EmployeesTask_ID int identity (1,1) primary key,
EmployeesTask_Titel nvarchar(30),
EmployeesTask_Description nvarchar(30),
EmployeesTask_Status nvarchar(15),
EmployeesTask_DueDate datetime
)
insert into EmployeesTasks values('fronted','Finish the logain page','pending','03-21-2024 12:0:0'),
('backend','Add the payment service','in progress','04-23-2024 10:0:0'),
('Deployment','Deploy the last version','completed','02-15-2024 8:0:0')
select * from EmployeesTasks
delete EmployeesTasks
