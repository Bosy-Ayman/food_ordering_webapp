USE FoodApp_Web;

CREATE TABLE customer (
    customer_id INT,
	customer_name VARCHAR(20),
	email CHAR(40),
	the_Address VARCHAR(30),
	phone_number INT,
	the_Password  CHAR(30),
	FOREIGN KEY (customer_id) REFERENCES users(customer_id)
);

CREATE TABLE users (
    users_id INT PRIMARY KEY,
	the_password char(30),
	username char(30),
    customer_id INT PRIMARY KEY,
);

CREATE TABLE administrator (
    admin_id INT PRIMARY KEY,
    admin_name CHAR(20),
    email CHAR(40),
    phone_number INT,
    the_password CHAR(10),
    users_id INT,  
    FOREIGN KEY (users_id) REFERENCES users(users_id)
);

CREATE TABLE menu(
	manu_name varCHAR(30),
	price INT,
	category char(20),
	admin_id INT,  
    FOREIGN KEY (admin_id) REFERENCES administrator(admin_id)
);

CREATE TABLE payment(
    amount int,
	code INT,
	coupon_id INT,
	The_type Char(20),
	customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES users(customer_id),
	FOREIGN KEY (coupon_id) REFERENCES promotion(coupon_id)
);

CREATE TABLE cart (
    cart_id INT PRIMARY KEY,
	order_item_id INT,
	item_amount INT,
	total_price INT,
	FOREIGN KEY (order_item_id) REFERENCES order_items(order_item_id),
);

CREATE TABLE the_order (
    order_id INT Primary KEY,	
    customer_id INT,
    FOREIGN KEY (customer_id) REFERENCES users(customer_id),
    the_status CHAR(20),
    total_price DECIMAL(10, 5),
    OrderDateTime DATE
);

CREATE TABLE promotion (
    coupon_id INT primary key, 
    code VARCHAR(20),	 
    discount_Percentage FLOAT,
    order_id INT,
    FOREIGN KEY (order_id) REFERENCES the_order(order_id)
);

CREATE TABLE review (
 review_id int primary key,
 rate int,
 comment varchar(30),
 the_date Date
);

CREATE TABLE CustomerReviews(
review_id INT, FOREIGN KEY (review_id) REFERENCES review(review_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES users(customer_id),
);

CREATE TABLE CustomerPayments(
coupon_id INT, FOREIGN KEY (coupon_id) REFERENCES promotion(coupon_id),
customer_id INT, FOREIGN KEY (customer_id) REFERENCES users(customer_id),
);


CREATE TABLE Has_order(
order_item_id INT, FOREIGN KEY (order_item_id) REFERENCES order_items(order_item_id),
order_id INT, FOREIGN KEY (order_id) REFERENCES the_order(order_id),
);

CREATE TABLE order_items(
image_url varchar(30),
order_item_id int primary key,
cart_id int,
users_id int,
FOREIGN KEY (cart_id) REFERENCES cart(cart_id),
FOREIGN KEY (users_id) REFERENCES users(users_id),
);


create table customizations (
customization_id int primary key,
price DECIMAL(10,5),
the_description VARCHAR(30),
availibility char(20)
);

Create table OrderItemCustmization(
order_item_id INT,
FOREIGN KEY (order_item_id) REFERENCES order_items(order_item_id),
customization_id INT,
FOREIGN KEY (customization_id) REFERENCES customizations(customization_id)
);
