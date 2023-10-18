use master
go

create database ShiftsManagerDB
go
use ShiftsManagerDB
go

---- schema ----
CREATE TABLE Users (
  userID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  userName varchar(40) not null,
  userRate DECIMAL NULL,
  isClockedIn BIT not null
  );
   
CREATE TABLE Shifts (
  shiftID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  shiftClockInDate datetime not null,
  shiftClockOut datetime null,
  userID INT FOREIGN KEY REFERENCES Users(userID) NOT NULL
);

CREATE TABLE Payments (
	paymentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	paymentAmount decimal not null,
	paymentDate datetime not null,
	userID INT FOREIGN KEY REFERENCES Users(userID) NOT NULL
);


---- data ----
insert into Users(userName,isClockedIn)
values('Sara Green',0),('Rivka Rosen',0),('Atara A',0)
