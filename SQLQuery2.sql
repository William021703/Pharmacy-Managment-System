use PharmacySystem;

CREATE TABLE Employee
(
    EmployeeID INT NOT NULL IDENTITY(1,1),
    Username VARCHAR(100) NOT NULL UNIQUE,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE
        CHECK (Email LIKE '%@%'),
    PasswordHash VARCHAR(255) NOT NULL,
    PIN INT NOT NULL UNIQUE,

    CONSTRAINT PK_Employee PRIMARY KEY (EmployeeID)
);
GO

create table Roles
(
RoleId int not null identity(1,1),
RoleName varchar(25),

constraint PK_Roles PRIMARY KEY(RoleId)
);
go

create table Patient(
PatientId int not null identity(1,1),
PatientRirstName varchar(25) not null,
PatientLastName varchar(25) not null,
PatientAge int not null ,




constraint PK_Patient_id primary key(PatientId),
constraint CK_Patient_age check( PatientAge >= 18)
);
go





