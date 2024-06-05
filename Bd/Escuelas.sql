create database escuelas;
use escuelas;

create table alumnos(
id int auto_increment not null primary key,
nombres nvarchar(50),
apellidos nvarchar(50)
);

insert into alumnos values (null, "Fede", "Velho");
insert into alumnos value (null, "Juan", "Perez");
insert into alumnos value (null, "Valentina", "Fuentes");
 
select * from alumnos;