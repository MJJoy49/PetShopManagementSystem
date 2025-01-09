-- Step 1: Create the Database
CREATE DATABASE PetMate;
USE PetMate;

-- Step 2: Create Tables (Normalized to 3NF)

-- Table: Users
CREATE TABLE Users (
    UserName VARCHAR(50) PRIMARY KEY,
    Password VARCHAR(50),
	Name VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(15),
    Role VARCHAR(20),
    HouseOrBuildingOrFlatNumber VARCHAR(50),
    StreetNameOrNumber VARCHAR(100),
    CityOrAreaName VARCHAR(50),
    PostalCode VARCHAR(10),
    QuestionOne TEXT,
    QuestionTwo TEXT,
    QuestionThree TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);


-- Table: Admin
CREATE TABLE Admin (
    AdminID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE
);

-- Table: Customer
CREATE TABLE Customer (
    CustomerID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE
);




-- Table: Employee
CREATE TABLE Employee (
    EmployeeID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    Salary DECIMAL(10, 2),
    HireDate DATE,
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE
);

-- Table: Pet
CREATE TABLE Pet (
    PetID VARCHAR(50) PRIMARY KEY,
    Name VARCHAR(50),
    Type VARCHAR(50),
    Gender VARCHAR(10),
    Breed VARCHAR(50),
    Price DECIMAL(10, 2),
    Description TEXT,
    AgeRange VARCHAR(20),
    Stock INT,
    HealthStatus VARCHAR(50)
);

-- Table: Accessories
CREATE TABLE Accessories (
    AccessoryID VARCHAR(50) PRIMARY KEY,
    Name VARCHAR(50),
    Type VARCHAR(50),
    Material VARCHAR(50),
    Price DECIMAL(10, 2),
    Description TEXT,
	SuitableFor VARCHAR(30),
    Stock INT,
    Brand VARCHAR(50),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Table: AddCart
CREATE TABLE AddCart (
    CartID VARCHAR(50) PRIMARY KEY,
    CustomerID VARCHAR(50),
    ItemID VARCHAR(50),
    ItemType VARCHAR(20),
    Quantity INT,
    AddedDate DATETIME,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE
);



-- Table: CustomerOrder
CREATE TABLE CustomerOrder (
    OrderID VARCHAR(50) PRIMARY KEY,
    CustomerID VARCHAR(50),
    CartID VARCHAR(50),
    TotalAmount DECIMAL(10, 2),
    OrderStatus VARCHAR(50),
    OrderDate DATETIME,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE NO ACTION,
    FOREIGN KEY (CartID) REFERENCES AddCart(CartID) ON DELETE NO ACTION
);


-- Table: Payment
CREATE TABLE Payment (
    PaymentID VARCHAR(50) PRIMARY KEY,
    CustomerID VARCHAR(50),
    OrderID VARCHAR(50),
    Amount DECIMAL(10, 2),
    PaymentMethod VARCHAR(50),
    TransactionID VARCHAR(100),
    PaymentStatus VARCHAR(50),
    PaymentDate DATETIME,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (OrderID) REFERENCES CustomerOrder(OrderID) ON DELETE CASCADE
);

-- Table: Adoption
CREATE TABLE Adoption (
    AdoptionID VARCHAR(50) PRIMARY KEY,
    PetID VARCHAR(50),
    CustomerID VARCHAR(50),
    RequestDate DATETIME,
    AcceptanceStatus VARCHAR(50),
    Description TEXT,
    FOREIGN KEY (PetID) REFERENCES Pet(PetID) ON DELETE CASCADE,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE
);

-- Table: Volunteer
CREATE TABLE Volunteer (
    VolunteerID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    TasksCompleted INT,
    RewardPoints INT,
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE
);

-- Table: HelpRequest
CREATE TABLE HelpRequest (
    HelpRequestID VARCHAR(50) PRIMARY KEY,
    CustomerID VARCHAR(50),
    PetID VARCHAR(50),
    VolunteerID VARCHAR(50),
    HelpDescription TEXT,
    Status VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE NO ACTION,
    FOREIGN KEY (PetID) REFERENCES Pet(PetID) ON DELETE NO ACTION,
    FOREIGN KEY (VolunteerID) REFERENCES Volunteer(VolunteerID) ON DELETE NO ACTION
);


-- Table: Notification
CREATE TABLE Notification (
    NotificationID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    Message TEXT,
    Status VARCHAR(50),
    SentDate DATETIME,
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE
);


INSERT INTO Users (UserName, Password, Email, Phone, Role, CreatedAt, UpdatedAt,Name)
VALUES ('admin01', 'admin01', 'damo01admin@gmail.com', '01234567890', 'Admin', GETDATE(), GETDATE(),'mr.demo');




----------------------end---------------------------------------------------




-- Example Insert Queries

-- Insert Example Data into Users Table
INSERT INTO Users (UserName, Password, Email, Phone, Role, CreatedAt, UpdatedAt)
VALUES ('mr.Damo', 'admin01', 'damo01admin@gmail.com', '01234567890', 'Admin', NOW(), NOW()),
       ('jane_customer', 'password456', 'jane@example.com', '0987654321', 'Customer', NOW(), NOW());

-- Insert Example Data into Pet Table
INSERT INTO Pet (PetID, Name, Type, Gender, Breed, Price, Description, AgeRange, Stock, HealthStatus)
VALUES ('P001', 'Bella', 'Dog', 'Female', 'Labrador', 500, 'Friendly and playful', 'Adult', 10, 'Healthy'),
       ('P002', 'Whiskers', 'Cat', 'Male', 'Persian', 300, 'Calm and affectionate', 'Young', 5, 'Healthy');

-- Insert Example Data into AddCart Table
INSERT INTO AddCart (CartID, CustomerID, ItemID, ItemType, Quantity, AddedDate)
VALUES ('C001', 'CUST001', 'P001', 'Pet', 1, NOW()),
       ('C002', 'CUST001', 'A001', 'Accessory', 2, NOW());
