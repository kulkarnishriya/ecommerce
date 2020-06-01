Use eWebsitedb

DROP TABLE IF EXISTS eWebsitedb.dbo.Address;
CREATE TABLE eWebsitedb.dbo.Address
(Id int NOT NULL PRIMARY KEY,
FirstName varchar(max) NOT NULL,
LastName varchar(max) NOT NULL,
EmailId varchar(max) NOT NULL,
Address1 varchar(max) NOT NULL,
City varchar(max) NOT NULL,
Country varchar(max) NOT NULL,
Zip int NOT NULL,
Phone int NOT NULL);

DROP TABLE IF EXISTS eWebsitedb.dbo.WebsiteUser;
CREATE TABLE eWebsitedb.dbo.WebsiteUser
(id int NOT NULL PRIMARY KEY,
Name varchar NOT NULL,
EmailId varchar NOT NULL,
AddressId int NULL);


DROP TABLE IF EXISTS eWebsitedb.dbo.Product;
CREATE TABLE eWebsitedb.dbo.Product
(Id int NOT NULL PRIMARY KEY,
Name varchar NOT NULL,
Price float NOT NULL,
OldPrice float NOT NULL,
StockQuantity int NOT NULL,
Category varchar NULL,
Description varchar NULL,
AddedBy varchar NOT NULL,
ImageId int NULL,
DateAdded datetime NOT NULL);

DROP TABLE IF EXISTS eWebsitedb.dbo.Img;
CREATE TABLE eWebsitedb.dbo.Img
(Id int NOT NULL PRIMARY KEY,
BlobUrl varchar NULL);

DROP TABLE IF EXISTS eWebsitedb.dbo.Cart;
CREATE TABLE eWebsitedb.dbo.Cart
(ProductId int NOT NULL,
UserId int NOT NULL,
Quantity int NOT NULL);

DROP TABLE IF EXISTS eWebsitedb.dbo.History;
CREATE TABLE eWebsitedb.dbo.History
(UserId int NOT NULL,
ProductId int NOT NULL,
Quantity int NOT NULL,
Price int NOT NULL,
DateofPurchase datetime NOT NULL,
Action varchar NOT NULL);