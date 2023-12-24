create database ProyectoFinal;

use ProyectoFinal;

--TODO: Crear tabla login
create table Usuario_Docente
(
  id int identity primary key,
  nombre varchar(50)not null,
  apeP varchar(50)not null,
  apeM varchar(50)null,
  username varchar(100)not null,
  tipo varchar(30)not null,
  doc bigint not null,
  correo varchar(50)not null,
  -- contra varchar(10)not null,
  contra varbinary  not null,
);
--TODO: Crear tabla ubigeo
create table Ubigeo
(
  ubigeo nvarchar(6) primary key,
  dpto nvarchar(30),
  prov nvarchar(30),
  distrito nvarchar(30),
)
--TODO: Crear tabla de datos del docente
--NOTE: Esta tabla tiene dependencia de Usuario_Docente y Ubigeo
create table RegistroDocente
(
  id int,
  sexo varchar(15),
  estadoCivil varchar(20),
  direccion varchar(50),
  ubigeo nvarchar (6),
  telefono varchar(20),
  celular varchar (20),
  foto varchar(50),
  fNacimiento date,
  fRegistro date,
  fModficacion date,
  precio_Hora decimal(10,2),
  foreign key (id) references  Usuario_Docente(id),
  foreign key (ubigeo) references Ubigeo(ubigeo)
);
--TODO: Crear tabla de discapacidad
--NOTE: Esta tabla tiene dependencia de Usuario_Docente
create table Discapacidad
(
  id int,
  idDiscapacidad int identity primary key,
  discapacidad varchar(50),
  descDiscapacidad text,
  foreign key (id) references Usuario_Docente(id)
)
--TODO: Crear tabla de datos academicos del docente
--NOTE: Esta tabla tiene dependencia de Usuario_Docente
create table DatosAcademicos
(
  idDatos int identity primary key,
  id int,
  titulo varchar (100),
  centroEstudios varchar (100),
  fechaGrado date,
  subirTitulo varchar (50),
  foreign key (id) references Usuario_Docente(id)
);
--TODO: Crear tabla de experiencias del docente
--NOTE: Esta tabla tiene dependencia de Usuario_Docente
create table Experencias
(
  idExpe int identity primary key,
  id int,
  f_Inicio date,
  f_Fin date,
  cargo varchar(100),
  empresa varchar(100),
  certificado varchar (100),
  foreign key (id) references Usuario_Docente(id)
);
--TODO: Crear tabla de los cursos disponible
create table Cursos
(
  idCurso int identity primary key,
  curso varchar (100),
);
--TODO: Crear tabla de los cursos que dictara el docente
--NOTE: Esta tabla tiene dependencia de Usuario_Docente y Cursos
create table Curso_Dictado
(
  idCurso int,
  id int,
  foreign key (id) references Usuario_Docente(id),
  foreign key (idCurso) references Cursos(idCurso)
);
