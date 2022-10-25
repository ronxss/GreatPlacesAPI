CREATE TABLE Attractions (
Id int identity(1, 1) primary key,
Name varchar(255),
Description varchar(100),
Localization varchar(255),
City varchar(255),
State varchar(255),
InclusionDate date,
);