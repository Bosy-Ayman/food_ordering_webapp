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
    Admin_name VARCHAR,
    Email CHAR(40),
    phone_number INT,
    Password CHAR(10),
    user_ID INT,  
    FOREIGN KEY (user_ID) REFERENCES users(ID)
);
DROP TABLE IF EXISTS  Menu ;

CREATE TABLE Menu(
	Name VARCHAR,
	Price INT,
	Category char(20),
	 Admin_ID INT,  
    FOREIGN KEY (Admin_ID) REFERENCES Administrator(Admin_ID)
);
DROP TABLE IF EXISTS Promotion ;

CREATE TABLE Payment(
	code INT,
	Coupon_ID INT Primary key, -- is it primary key?
	Type Char(20),
	customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

CREATE TABLE cart (
    Cart_ID INT PRIMARY KEY
);

CREATE TABLE The_Order (
    Order_ID INT Primary KEY,	
    customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
    Status varchar,
    Total_Price DECIMAL(10, 2),
    OrderDateTime DATETIME
);

CREATE TABLE Promotion (
    Coupon_ID INT Primary key,  -- is it P_KEY?
    Code VARCHAR,	 
    Discount_Percentage FLOAT,
    Order_ID INT,
    FOREIGN KEY (Order_ID) REFERENCES The_Order(Order_ID)
);

CREATE TABLE Review (
 Review_id int primary key,
 rate int,
 comment varchar,

);

CREATE TABLE Makes_review(
Review_id INT, FOREIGN KEY (Review_id) REFERENCES Review(Review_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES customer(customer_id),

);

CREATE TABLE Makes_order(
order_id INT, FOREIGN KEY (order_id) REFERENCES The_Order(order_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES customer(customer_id),

);

CREATE TABLE Makes_payment(
Review_id INT, FOREIGN KEY (Review_id) REFERENCES Review(Review_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
);


CREATE TABLE Has_order(
order_itemsID INT, FOREIGN KEY (order_itemsID) REFERENCES Orderitems(order_itemsID),
order_id INT, FOREIGN KEY (order_id) REFERENCES The_Order(order_id),
);