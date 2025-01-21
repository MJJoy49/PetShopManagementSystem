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
    QuestionOneAns VARCHAR(50),
    QuestionTwoAns VARCHAR(50),
    QuestionThreeAns VARCHAR(50),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);


-- Table: Customer
CREATE TABLE Customer (
    CustomerID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE
);


-- Table: Admin
CREATE TABLE Admin (
    AdminID VARCHAR(50) PRIMARY KEY,
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
    HealthStatus VARCHAR(50),
	PetImg VARBINARY(MAX)
);

-- Table: BuyPet 
CREATE TABLE BuyPet (
    BuyPetID VARCHAR(50) PRIMARY KEY,         
    CustomerID VARCHAR(50),                   
    PetID VARCHAR(50),                        
    AdoptionRequestID VARCHAR(50),            
    PurchaseDate DATETIME,                    
    Price DECIMAL(10, 2),                     
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (PetID) REFERENCES Pet(PetID) ON DELETE CASCADE
);



-- Table: Accessories
CREATE TABLE Accessories (
    AccessoryID VARCHAR(50) PRIMARY KEY,
    Name VARCHAR(50),
    Price DECIMAL(10, 2),
    Description TEXT,
	SuitableFor VARCHAR(30),
    Stock INT,
	Category VARCHAR(50),
    Brand VARCHAR(50),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
	AccessoriesImg VARBINARY(MAX)
);



-- Table: AddCart (Customer's Cart with Pet and Accessories)
CREATE TABLE AddCart (
    AddCardId INT IDENTITY(1,1) PRIMARY KEY,  
    CartID VARCHAR(50),                
    CustomerID VARCHAR(50),
    ItemID VARCHAR(50),                       
    ItemType VARCHAR(20),                    
    Quantity INT,
    AddedDate DATETIME,
    CartStatus VARCHAR(20) DEFAULT 'Active',
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
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE NO ACTION
);


-- Table: AddFavourite
CREATE TABLE AddFavourite (
    FavouriteID VARCHAR(50) PRIMARY KEY, 
    UserName VARCHAR(50),
    AccessoriesID VARCHAR(50),
    PetID VARCHAR(50),
    AddedDate DATETIME,
    FOREIGN KEY (UserName) REFERENCES Users(UserName) ON DELETE CASCADE,
    FOREIGN KEY (AccessoriesID) REFERENCES Accessories(AccessoryID) ON DELETE CASCADE,
    FOREIGN KEY (PetID) REFERENCES Pet(PetID) ON DELETE CASCADE
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

CREATE TABLE BuyPet (
    BuyPetID VARCHAR(50) PRIMARY KEY,         
    CustomerID VARCHAR(50),                    
    PetID VARCHAR(50),                         
    AdoptionRequestID VARCHAR(50),             
    PurchaseDate DATETIME,                     
    Price DECIMAL(10, 2),                      
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (PetID) REFERENCES Pet(PetID) ON DELETE CASCADE
);



-- Table: Volunteer
CREATE TABLE Volunteer (
    VolunteerID VARCHAR(50) PRIMARY KEY,
    UserName VARCHAR(50),
    TasksCompleted INT,
    RewardPoints INT,
	WorkActiveStatus BIT NOT NULL DEFAULT 0,
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
VALUES ('admin', 'admin', 'admin@gmail.com', '01234567890', 'Admin', GETDATE(), GETDATE(),'mr.demo');


INSERT INTO Admin (AdminID, UserName)
VALUES ('A1-001-25', 'admin');




----------------------end---------------------------------------------------


SELECT hr.CustomerID, hr.PetID, hr.HelpDescription, u.UserName, u.Phone, u.CityOrAreaName 
                                                FROM HelpRequest hr
                                                INNER JOIN Users u ON hr.CustomerID = u.UserName
                                                WHERE hr.VolunteerID = 'V1-02-25' AND hr.Status = 'not accepted'

select * from HelpRequest WHERE VolunteerID = 'V1-02-25'

SELECT hr.CustomerID, hr.PetID, hr.HelpDescription, u.UserName, u.Phone, u.CityOrAreaName
FROM HelpRequest hr
INNER JOIN Users u ON hr.CustomerID = u.UserName
WHERE LTRIM(RTRIM(hr.VolunteerID)) = 'V1-02-25' AND hr.Status = 'not accepted';
