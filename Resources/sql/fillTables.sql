INSERT INTO customer_title(title) VALUES ('Mr');
INSERT INTO customer_title(title) VALUES ('Mrs');
INSERT INTO customer_title(title) VALUES ('Ms');
INSERT INTO customer_title(title) VALUES ('Dr');

INSERT INTO customer(title_id,first_name,surname,email) VALUES (1,'John','Smith','john@gmail.com');
INSERT INTO customer(title_id,first_name,surname,email) VALUES (3,'Jane','Doe','jane@gmail.com');
INSERT INTO customer(title_id,first_name,surname,email) VALUES (1,'Jeff','Jones','jeff@gmail.com');
INSERT INTO customer(title_id,first_name,surname,email) VALUES (4,'Ben','Dover','ben@gmail.com');
INSERT INTO customer(title_id,first_name,surname,email) VALUES (2,'Sally','Fields','sally@gmail.com');

INSERT INTO car_type(car_type_description) VALUES ('Sedan');
INSERT INTO car_type(car_type_description) VALUES ('Hatchback');
INSERT INTO car_type(car_type_description) VALUES ('Sport');
INSERT INTO car_type(car_type_description) VALUES ('Luxury');
INSERT INTO car_type(car_type_description) VALUES ('SUV');
INSERT INTO car_type(car_type_description) VALUES ('Van');

INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Toyota','Corolla',1);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Hyundai','Accent',1);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('VW','Golf',2);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Ford','Fiesta',2);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Toyota','Yaris',2);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('BMW','M4',3);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Audi','RS4',3);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Nissan','350z',3);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('BMW','X5',5);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Mercedes','GLC',5);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('VW','Caddy',6);
INSERT INTO car(car_make,car_model,car_type_id) VALUES ('Ford','EcoSport',5);

INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (1,1,'2018-03-25','2018-03-29');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (2,2,'2018-04-18','2018-04-22');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (3,3,'2018-04-22','2018-04-27');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (4,7,'2018-04-09','2018-04-13');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (1,11,'2018-05-06','2018-05-10');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (3,12,'2018-04-16','2018-04-20');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (5,10,'2018-05-03','2018-05-05');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (5,9,'2018-05-08','2018-05-18');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (2,4,'2018-05-09','2018-05-15');
INSERT INTO rental(customer_id,car_id,date_from,date_to) VALUES (3,3,'2018-05-10','2018-05-16');