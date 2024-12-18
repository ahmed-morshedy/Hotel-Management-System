create database Hotel_Management_System;

Create Table User_Table(
User_ID INT IDENTITY (1,1) NOT NULL,
User_Name VARCHAR (150) NOT NULL,
User_Password VARCHAR(150) NOT NULL,
CONSTRAINT User_Table_User_ID_PK PRIMARY KEY (User_ID)
);

Create Table Client_Table(
Client_ID INT IDENTITY (1,1) NOT NULL,
Client_FirstName VARCHAR (150) NOT NULL,
Client_LastName VARCHAR (150) NOT NULL,
Client_Phone VARCHAR (11) UNIQUE NOT NULL,
Client_Address VARCHAR (150) NOT NULL,

CONSTRAINT Client_Table_Client_ID_PK PRIMARY KEY (Client_ID)
);

CREATE TABLE Room_Table 
(
Room_Number INT IDENTITY (1,1) NOT NULL,
Room_Type VARCHAR(6) NOT NULL , 
Room_Phone VARCHAR (11) UNIQUE NOT NULL,
Room_Free VARCHAR (3) NOT NULL,

CONSTRAINT Room_Table_Room_Number_PK PRIMARY KEY (Room_Number)
);

CREATE TABLE Reservation_Table
(
  Reservation_ID INT IDENTITY (1,1) NOT NULL,
  Reservation_Room_Type VARCHAR (6) NOT NULL,
  Reservation_Room_Number INT NOT NULL,
  Reservation_Client_ID INT UNIQUE NOT NULL,
  Reservation_In VARCHAR(32) NOT NULL ,
  Reservation_Out VARCHAR(32) NOT NULL ,

CONSTRAINT Reservation_Table_Reservation_ID_PK PRIMARY KEY (Reservation_ID)
)



INSERT INTO User_Table VALUES ('test','1234')

INSERT INTO Client_Table VALUES 
('Ahmed','Ali','0100000154','EG'),
('Mohamed','Nour','0145000154','US'),
('Said','Reda','0175000154','FR');

INSERT INTO Room_Table VALUES 
('Single','1231541','YES'),
('Family','5441','No');

