
CREATE TABLE ProductModelEntity (
    ID INT PRIMARY KEY NOT NULL,
    ModelName VARCHAR(50) NOT NULL
);


CREATE TABLE ProductOrderEntity (
    ID INT PRIMARY KEY NOT NULL,
    OrderDate DATE NOT NULL
);


CREATE TABLE ProductDetailsEntity (
    ID INT PRIMARY KEY NOT NULL,
    Color VARCHAR(50) NOT NULL,
    Description VARCHAR(MAX) NULL
);


CREATE TABLE ProductEntity (
    ProductID INT PRIMARY KEY NOT NULL,
    ProductName VARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    ProductOrderEntityID INT NOT NULL REFERENCES ProductOrderEntity(ID),
    ProductModelEntityID INT NOT NULL REFERENCES ProductModelEntity(ID),
    ProductDetailsEntityID INT NOT NULL REFERENCES ProductDetailsEntity(ID)
);


CREATE TABLE CategoryEntity (
    CategoryID INT PRIMARY KEY NOT NULL,
    CategoryName VARCHAR(50) NOT NULL UNIQUE,
    ProductID INT NOT NULL REFERENCES ProductEntity(ProductID)
);
