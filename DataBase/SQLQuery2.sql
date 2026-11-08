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
PatientId v
);
go





