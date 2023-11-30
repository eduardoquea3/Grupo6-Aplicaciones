create database ProyectoFinal

use ProyectoFinal

create table Usuario_Docente(
idUsuario int identity primary key,
nombreUsuario varchar(200) not null,
contraseña varchar (20) not null,
nombre varchar (100) not null,
apellido varchar(100) not null,
dni  int  not null,
tipoDocumento varchar(50),
correoElectronico varchar(100) not null
);
create table RegistroDocente(
idUsuario int,
sexo varchar(50),
esatdoCivil varchar(50),
direccion varchar(100),
ubigeo  varchar (200),
discapacidad varchar(100),
discripcionDiscapacidad varchar (100),
telefono  varchar(20),
celular varchar (20),
foto  varchar(50),
fechaRegistro DATE,
fechaModficacion DATE,
foreign key (idUsuario) references  Usuario_Docente(idUsuario)
);
create table  DatosAcademicos (
idDatosA int identity primary key,
idUsuario int,
titulo_Grado varchar (100),
centroEstudios varchar (100),
fechaGrado_Obtenido date,
subirTitulo varchar (50),
foreign key (idUsuario) references Usuario_Docente(idUsuario)
);

create table Experencias (
idExperencia int identity primary key,
idUsuario int,
fecha_Inicio date,
fecha_Fin date,
cargo varchar (100),
nombre_empresa varchar(100),
subir_Certificado varchar (100)
foreign key (idUsuario) references Usuario_Docente(idUsuario)
);

create table curso_Dictados(
idCurso int,
idUsuario int,
foreign key (idUsuario) references Usuario_Docente(idUsuario),
foreign key (idCurso) references cursos(idCurso)
);
alter table RegistroDocente
add  precio_Hora decimal (10,2)

create table cursos(
idCurso int identity primary key ,
nombre_Curso varchar (100),
);
CREATE TABLE  ubigeo (  ubigeo char(6) primary key,  dpto varchar(32),  prov varchar(32),  distrito varchar(32), );






