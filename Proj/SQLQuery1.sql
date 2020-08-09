select * from MyFlights_CS
select * from Airlines_CS
select * from Airports_CS
select * from Discount_CS

delete from MyFlights_CS
delete from Airlines_CS
delete from Airports_CS
delete from Discount_CS

CREATE TABLE Discount_CS(
Id int IDENTITY(0,1) PRIMARY KEY,
Code varchar(100),
CityFrom varchar(50),
CityTo varchar(50),
TimeO varchar(50),
TimeI varchar(50),
CompanyDiscount varchar(50),

)
