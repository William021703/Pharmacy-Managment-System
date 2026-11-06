use PharmacySystem;

create table usuario(
id_usuario int not null identity(1,1),
username varchar(100) not null unique,
nombre varchar(50) not null,
apellido varchar(50) not null,
correo varchar(100) not null unique check (correo like '%@%'),
contraseña varchar(20) not null
pin int not null unique,

constraint pk_usuario primary key(id_usuario)

);