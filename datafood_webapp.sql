USE datafood_webapp;

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
    Admin_name VARCHAR(20),
    Email varchar(50),
    phone_number INT,
    Password CHAR(10),
    user_ID INT,  
    FOREIGN KEY (user_ID) REFERENCES users(ID)
);

CREATE TABLE Menu(
	Name VARCHAR,
	Price INT,
	Category varchar(20),
	 Admin_ID INT,  
    FOREIGN KEY (Admin_ID) REFERENCES Administrator(Admin_ID)
);
CREATE TABLE Payment(
	code INT,
	Coupon_ID INT Primary key,
	Type varChar(20),
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
    Status varchar(50),
    Total_Price DECIMAL(10, 2),
    OrderDateTime DATETIME
);

CREATE TABLE Promotion (
    Coupon_ID INT Primary key,  
    Code VARCHAR(10),	 
    Discount_Percentage FLOAT,
    Order_ID INT,
    FOREIGN KEY (Order_ID) REFERENCES The_Order(Order_ID)
);

CREATE TABLE Review (
 Review_id int primary key,
 rate int,
 comment varchar(200),

);

CREATE TABLE Makes_review(
Review_id INT, FOREIGN KEY (Review_id) REFERENCES Review(Review_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES customer(customer_id),

);


CREATE TABLE Makes_payment(
Review_id INT, FOREIGN KEY (Review_id) REFERENCES Review(Review_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
);


CREATE TABLE order_items(
    order_item_ID int Primary key,
	order_iD int,
	image_url varchar ,
	menu_item_id INT,
	cart_id int,
	user_id int,
	items_id int ,
);

CREATE TABLE Has_order(
order_item_ID INT, FOREIGN KEY (order_item_ID) REFERENCES Order_items(order_item_ID),
Order_ID INT, FOREIGN KEY (Order_ID) REFERENCES The_Order(Order_ID),
);
CREATE TABLE Makes_order(
order_id INT, FOREIGN KEY (order_id) REFERENCES The_Order(order_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES customer(customer_id),

);
CREATE TABLE order_has_cust(
order_item_ID INT,
FOREIGN KEY (order_item_ID) REFERENCES order_items(order_item_ID),
FOREIGN KEY (customization_id) REFERENCES order_has_cust(customization_id),

customization_id INT primary KEY,
);
CREATE TABLE customizations (
	customization_id INT primary KEY,
	price INT  ,
	availability varchar(10) ,
	description char,
);


