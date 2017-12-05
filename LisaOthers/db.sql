CREATE DATABASE LisaDB;
USE LisaDB;

CREATE TABLE Operation(
    ID INT NOT NULL AUTO_INCREMENT,
    Code VARCHAR(100) NOT NULL,
    Title VARCHAR(250) NOT NULL,
    StartTime DATE NOT NULL,
    EndTime DATE NOT NULL,
    PRIMARY KEY(ID)
)ENGINE=INNODB;

CREATE TABLE Catalog(
    ID INT NOT NULL AUTO_INCREMENT,
    Type VARCHAR(100) NOT NULL,
    Label VARCHAR(500) NOT NULL,
    Speed VARCHAR(50) NOT NULL,
    Width INT NOT NULL,
    Height INT NOT NULL,
    PRIMARY KEY(ID)
)ENGINE=INNODB;

CREATE TABLE Page(
    ID INT NOT NULL AUTO_INCREMENT,
    Num INT NOT NULL,
    IDCatalog INT NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY fk_page_catalog (IDCatalog) REFERENCES Catalog(ID)
)ENGINE=INNODB;

CREATE TABLE Shop(
    ID INT NOT NULL AUTO_INCREMENT,
    DisplayStartDate DATE NOT NULL,
    DisplayEndDate DATE NOT NULL,
    PRIMARY KEY(ID)
)ENGINE=INNODB;

CREATE TABLE Product(
    ID INT NOT NULL AUTO_INCREMENT,
    Code VARCHAR(100) NOT NULL,
    Label VARCHAR(500) NOT NULL,
    Description VARCHAR(2000) NOT NULL,
    Category VARCHAR(100) NOT NULL,
    Price DOUBLE NOT NULL,
    Ecotaxe DOUBLE NOT NULL,
    ImagePath VARCHAR(1000) NOT NULL,
    PictoPath VARCHAR(1000) NOT NULL,
    Origin VARCHAR(500) NOT NULL,
    Mention VARCHAR(500) NOT NULL,
    LowerPrice DOUBLE NOT NULL,
    Color VARCHAR(100) NOT NULL,
    PRIMARY KEY(ID)
)ENGINE=INNODB;

CREATE TABLE Technician(
    ID INT NOT NULL AUTO_INCREMENT,
    Login VARCHAR(500) NOT NULL,
    Password VARCHAR(500) NOT NULL,
    PRIMARY KEY(ID)
)ENGINE=INNODB;

CREATE TABLE PageProduct(
    IDPage INT NOT NULL,
    IDProduct INT NOT NULL,
    PRIMARY KEY(IDPage,IDProduct),
    FOREIGN KEY fk_pageproduct_page (IDPage) REFERENCES Page(ID),
    FOREIGN KEY fk_pageproduct_product (IDProduct) REFERENCES Product(ID)
)ENGINE=INNODB;

CREATE TABLE OperationCatalog(
    IDOperation INT NOT NULL,
    IDCatalog INT NOT NULL,
    PRIMARY KEY(IDOperation,IDCatalog),
    FOREIGN KEY fk_operationcatalog_operation (IDOperation) REFERENCES Operation(ID),
    FOREIGN KEY fk_operationcatalog_catalog (IDCatalog) REFERENCES Catalog(ID)
)ENGINE=INNODB;

CREATE TABLE OperationShop(
    IDOperation INT NOT NULL,
    IDShop INT NOT NULL,
    PRIMARY KEY(IDOperation,IDShop),
    FOREIGN KEY fk_operationshop_operation (IDOperation) REFERENCES Operation(ID),
    FOREIGN KEY fk_operationshop_shop (IDShop) REFERENCES Shop(ID)
)ENGINE=INNODB;