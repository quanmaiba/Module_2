--CREATE DATABASE QLSV
--USE QLSV

CREATE TABLE Student
(
	Id INT NOT NULL IDENTITY,
	FistName NVARCHAR(30),
	LastName NVARCHAR(60),
	CONSTRAINT PK_ID PRIMARY KEY(Id) 
)