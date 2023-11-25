USE food_webapp;

CREATE TABLE customer (
    customer_id INT PRIMARY KEY
);

CREATE TABLE users (
    ID INT PRIMARY KEY,
    customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);
CREATE TABLE Administrator (
    Admin_ID INT PRIMARY KEY,
    Admin_name CHAR(20),
    Email CHAR(40),
    phone_number INT,
    Password CHAR(10),
    user_ID INT,  
    FOREIGN KEY (user_ID) REFERENCES users(ID)
);
CREATE TABLE Menu(
	Name CHAR(10),
	Price INT,
	Category char(20),
	 Admin_ID INT,  
    FOREIGN KEY (Admin_ID) REFERENCES Administrator(Admin_ID)
);
CREATE TABLE Payment(
	code INT,
	Coupon_ID INT, -- is it primary key?
	Type Char(20),
	customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

CREATE TABLE cart (
    Cart_ID INT PRIMARY KEY
);

DROP TABLE IF EXISTS the_order;
CREATE TABLE The_Order (
    Order_ID INT Primary KEY,	
    customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
    Status CHAR(20),
    Total_Price DECIMAL(10, 2),
    OrderDateTime DATETIME
);

CREATE TABLE Promotion (
    Coupon_ID INT,  -- is it P_KEY?
    Code VARCHAR(20),	 
    Discount_Percentage FLOAT,
    Order_ID INT,
    FOREIGN KEY (Order_ID) REFERENCES The_Order(Order_ID)
);
