
DROP DATABASE manos_de_angel;

create database manos_de_angel;
use manos_de_angel;

Create table rol(
IdRol smallint not null primary key,
rolName varchar(10) not null
);

create table users(
IdUser bigint auto_increment not null primary key,
userName varchar(25) not null,
lastName varchar(30) not null,
Id varchar(9) not null,
email varchar(50) not null,
cellphone varchar (10) not null,
startDate date null,
ptoDays int null,
statusU bit not null,
passwordU varchar (30) not null,
IdRol smallint not null,
constraint fk_users_rol foreign key (idRol)
references rol(IdRol)
on delete cascade
on update cascade
);


create table fidelityProgram(
IdProgram bigint auto_increment not null primary key,
startDate date not null,
earnedPoints int not null,
IdUser bigint not null,
constraint fk_fidelity_user foreign key (IdUser)
references users(IdUser)
on delete cascade
on update cascade
);

create table reservation(
IdReservation bigint auto_increment not null primary key,
dateReservation date not null,
quantity int not null,
status_reser bit not null,
details varchar(150) not null,
IdUser bigint not null,
observations varchar(100) null,
constraint fk_reservation_user foreign key (IdUser)
references users(IdUser)
on delete cascade
on update cascade
);

Create table supplier(
IdSupplier bigint auto_increment not null primary key,
supplierName varchar(50) not null,
IdCorporate varchar(15) not null,
cellphone varchar(10) not null,
email varchar(50) not null
);

Create table product(
IdProduct bigint auto_increment not null primary key,
productName varchar(15) not null,
details varchar(100) not null,
stock int not null,
productStatus varchar(15) not null,
price int not null,
image LONGBLOB null,
IdSupplier bigint not null,
constraint fk_product_supplier foreign key (IdSupplier)
references supplier(IdSupplier)
on delete cascade
on update cascade
);

Create table logBook(
Idlog bigint auto_increment not null primary key,
logDate datetime not null,
origin varchar(100) not null,
message varchar(150) not null,
log_type varchar(15) not null,
IdUser bigint not null, 
constraint fk_logBook foreign key (IdUser)
references users(IdUser)
on delete cascade
on update cascade
);

INSERT INTO rol (idRol, rolName)
VALUES
    (1, 'Admin'),
    (2, 'Employee'),
    (3, 'Client');
    
INSERT INTO supplier (supplierName, IdCorporate, cellphone, email)
VALUES ('Super M', '222222', '1234567890', 'SuperMr@asc.com');

INSERT INTO product (productName, details, stock, productStatus, price, IdSupplier)
VALUES ('Arroz', 'Tio Pelon', 100, 'Disponible', 200, 1);

INSERT INTO product (productName, details, stock, productStatus, price, IdSupplier)
VALUES ('Frijoles', 'Tio Pelon', 100, 'Disponible', 200, 1);



select * from rol;
