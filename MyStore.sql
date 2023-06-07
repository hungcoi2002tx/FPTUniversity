create database MyStore
use MyStore
create table Categories(
	CategoryID int not null primary key,
	CategoryName nvarchar(15)
);
create table Products(
	ProductID int not null primary key,
	ProductName nvarchar(40),
	UnitPrice money,
	UnitInStock smallint,
	CategoryID int foreign key references
	Categories(CategoryID)
);
insert Categories values
(1,'Beverages'),
(2,'Condiments'),
(3,'Confections'),
(4,'Dairy Products'),
(5,'Grains/Cereals'),
(6,'Meat/Poultry'),
(7,'Produce'),
(8,'Seafood');

insert Products values
	(1,'Genen Shouyu',50,39,1),
	(2,'Alice Mutton',30,17,1),
	(3,'Aniseed Syrup',40,13,3),
	(4,'Perth Pasties',22,53,2),
	(5,'Carnarvon Tigers',21.35,0,4),
	(6,'Gula Malacca',25,120,2),
	(7,'Steeleye Stout',30,15,7),
	(8,'Chocolate',40,6,5),
	(9,'Mishi Kobe Niku',97,29,6),
	(10,'Ikura',31,31,8);