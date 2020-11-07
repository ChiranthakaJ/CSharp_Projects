CREATE DATABASE FirstDatabaseProject

USE FirstDatabaseProject

CREATE TABLE PersonalDetails (Index_No int NOT NULL PRIMARY KEY, 
First_Name varchar(25) NOT NULL, 
Last_Name varchar(25) NOT NULL, 
Res_Address varchar(25) NOT NULL)


--CREATE TABLE Persons (IDENTITY
--    Personid int NOT NULL AUTO_INCREMENT,
--    LastName varchar(255) NOT NULL,
--    FirstName varchar(255),
--    Age int,
--    PRIMARY KEY (Personid)
--);