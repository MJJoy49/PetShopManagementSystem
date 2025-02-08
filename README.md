# Pet-Shop Management System

## AMERICAN INTERNATIONAL UNIVERSITY–BANGLADESH (AIUB)  
### Dept. of Computer Science, Faculty of Science and Technology  
**CSC2210: OBJECT-ORIENTED PROGRAMMING 2**  
**Fall 2024-2025**  

**Section:** M  
**Group No:** 7  

### Project Report On
**Project Name: Pet-Shop Management System**  

#### Supervised by
**TOFAYET SULTAN**  



## Introduction
The **Pet-Shop Management System** is a comprehensive platform designed to simplify and enhance pet shop operations. It caters to four user roles—**Admin, Customer, Employee, and Volunteer**—ensuring seamless collaboration and efficient management. The system provides smooth functionality and superior service for all stakeholders with features like **secure logins, notifications, and a dynamic dashboard**.

## Project Description
The **Pet-Shop Management System (Petmate Shop)** is an advanced and user-friendly solution designed to streamline operations for a pet shop. This system integrates four distinct user roles—**Admin, Customer, Employee, and Volunteer**—each with specific features and functionalities tailored to their needs.

- **Admins** can manage pets, accessories, users, track orders, and monitor the shop’s performance.
- **Customers** can browse and purchase pets and accessories, request help, and manage their profiles.
- **Employees** can manage pets, accessories, orders, and customer interactions.
- **Volunteers** assist customers, earn reward points, and manage notifications.

Key features include **secure login, real-time notifications, help & support system, search & favorites, and a performance dashboard**. The system ensures a seamless and efficient user experience for all stakeholders.

---

## Key Features

### Admin Features
- **User Management:** Add, edit, remove users, manage profiles.
- **Pet Management:** Add, edit, remove pets, track purchases.
- **Accessories Management:** Manage pet-related accessories and inventory.
- **Order Management:** Accept, replace, manage orders, track statuses.
- **Dashboard:** Monitor total income, customers, business metrics.

### Customer Features
- **Profile Management:** Edit info, view purchase history.
- **Shopping:** Buy pets and accessories, use shopping cart.
- **Help Requests:** Request volunteer assistance, get notifications.
- **Notifications:** Get updates on orders, help requests.
- **Favorites & Search:** Mark favorites, search products/services.

### Employee Features
- **Pet & Accessories Management:** Add, edit, remove items.
- **User Management:** Manage customer and volunteer profiles.
- **Order Management:** Replace, deliver orders.
- **Profile Management:** Edit personal information.

### Volunteer Features
- **Help Request Management:** View and respond to help requests.
- **Profile Management:** Edit personal details.
- **Notifications:** Get updates on requests and tasks.
- **Rewards System:** Earn reward points (+10 per task).

### Additional Features
- **Secure Login System** (Admin, Customer, Employee, Volunteer).
- **Search Functionality** (Find pets, accessories, services).
- **Dashboard & Reports** (Monitor and analyze shop performance).
- **Help & Support System** (For customer assistance).
- **Real-time Notifications** (Orders, help requests, profile activities).

---

## Database Schema (3NF)

### Tables & Attributes
#### Users
- **Primary Key:** UserName
- **Attributes:** Password, Name, Email, Phone, Role, Address, Security Answers, CreatedAt, UpdatedAt

#### Other Tables
- **Customer (CustomerID, UserName)**
- **Admin (AdminID, UserName)**
- **Employee (EmployeeID, UserName, Salary, HireDate)**
- **Pet (PetID, Name, Type, Gender, Breed, Price, Description, AgeRange, Stock, HealthStatus, PetImg)**
- **Accessories (AccessoryID, Name, Price, Description, SuitableFor, Stock, Category, Brand, CreatedAt, UpdatedAt, AccessoriesImg)**
- **BuyPet (BuyPetID, CustomerID, PetID, AdoptionRequestID, PurchaseDate, Price)**
- **AddCart (CartID, CustomerID, ItemID, ItemType, Quantity, AddedDate, CartStatus)**
- **CustomerOrder (OrderID, CustomerID, CartID, TotalAmount, OrderStatus, OrderDate)**
- **AddFavourite (FavouriteID, UserName, AccessoriesID, PetID, AddedDate)**
- **Payment (PaymentID, CustomerID, OrderID, Amount, PaymentMethod, TransactionID, PaymentStatus, PaymentDate)**
- **Adoption (AdoptionID, PetID, CustomerID, RequestDate, AcceptanceStatus, Description)**
- **Volunteer (VolunteerID, UserName, TasksCompleted, RewardPoints, WorkActiveStatus)**
- **HelpRequest (HelpRequestID, CustomerID, PetID, VolunteerID, HelpDescription, Status)**
- **Notification (NotificationID, UserName, Message, Status, SentDate)**

---

## UI Designs

- **Login Form**
- **Signup Form**
- **Main Dashboard**
- **Inner Forms** (User Management, Pet Management, Orders, etc.)

---

## Diagrams

- **Activity Diagram**
- **Schema Diagram** (User, Admin, Customer, Employee, Volunteer, Help Requests, Notifications, Pets, Accessories, Orders, Payments, Adoptions, Favorites)


---

## License
This project is for academic purposes 

---

Thank you for reviewing our project documentation!
