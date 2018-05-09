CREATE TABLE customer_title
(
	customer_title_id INT IDENTITY(1,1) PRIMARY KEY,
	title VARCHAR(10)
);

CREATE TABLE customer 
(
	customer_id INT IDENTITY(1,1) PRIMARY KEY,
	title_id INT FOREIGN KEY REFERENCES customer_title(customer_title_id),
	first_name VARCHAR(50),
	surname VARCHAR(50),
	email VARCHAR(50)
);

CREATE TABLE car_type
(
	car_type_id INT IDENTITY(1,1) PRIMARY KEY,
	car_type_description VARCHAR(50)
);

CREATE TABLE car
(
	car_id INT IDENTITY(1,1) PRIMARY KEY,
	car_make VARCHAR(50),
	car_model VARCHAR(50),
	car_type_id INT FOREIGN KEY REFERENCES car_type(car_type_id)
);

CREATE TABLE rental
(
	rental_id INT IDENTITY(1,1) PRIMARY KEY,
	customer_id INT FOREIGN KEY REFERENCES customer(customer_id),
	car_id INT FOREIGN KEY REFERENCES car(car_id),
	date_from DATE,
	date_to DATE
);
