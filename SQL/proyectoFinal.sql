if not exists (select 1 from sys.databases where name = 'ProyectoFinal')
  create database ProyectoFinal

use ProyectoFinal;

--TODO: Crear tabla de los tipos de documento
create table TipoDocumento(
  id int primary key,
  tipo varchar(20)
)
--TODO: Crear tabla login
create table UsuarioDocente
(
  id int identity primary key,
  nombre varchar(50)not null,
  apeP varchar(50)not null,
  apeM varchar(50)null,
  username varchar(100)not null,
  tipo int not null,
  doc bigint not null,
  correo varchar(50)not null,
  contra varbinary(max)not null,
  foreign key (tipo) references TipoDocumento(id)
);
--TODO: Crear tabla ubigeo
create table Ubigeo
(
  ubigeo nvarchar(6) primary key,
  dpto nvarchar(30),
  prov nvarchar(30),
  distrito nvarchar(30),
)
--TODO: Crear tabla de los posibles estados civiles
create table EstadoCivil(
  id int primary key,
  estado varchar(30)
)
--TODO: Crear tabla de datos del docente
--NOTE: Esta tabla tiene dependencia de UsuarioDocente y Ubigeo
create table RegistroDocente
(
  id int not null,
  sexo int not null,
  estadoCivil int not null,
  direccion varchar(50)not null,
  ubigeo nvarchar (6)not null,
  telefono varchar(20)not null,
  celular varchar (20)not null,
  foto varchar(50)not null,
  fNacimiento date not null,
  fRegistro date not null,
  fModficacion date not null,
  precio_Hora decimal(10,2)not null,
  foreign key (id) references  UsuarioDocente(id),
  foreign key (ubigeo) references Ubigeo(ubigeo),
  foreign key (estadoCivil) references EstadoCivil(id),
  foreign key (sexo) references Sexo(id)
);
--TODO: Crear tabla de discapacidad
--NOTE: Esta tabla tiene dependencia de UsuarioDocente
create table Discapacidad
(
  id int not null,
  idDiscapacidad int identity primary key,
  discapacidad varchar(50) not null,
  descDiscapacidad text not null,
  foreign key (id) references UsuarioDocente(id)
)
--TODO: Crear tabla de datos academicos del docente
--NOTE: Esta tabla tiene dependencia de UsuarioDocente
create table DatosAcademicos
(
  idDatos int identity primary key,
  id int not null,
  titulo varchar (100)not null,
  centroEstudios varchar (100)not null,
  fechaGrado date not null,
  subirTitulo varchar (50)not null,
  foreign key (id) references UsuarioDocente(id)
);
--TODO: Crear tabla de experiencias del docente
--NOTE: Esta tabla tiene dependencia de UsuarioDocente
create table Experencias
(
  idExpe int identity primary key,
  id int not null,
  f_Inicio date not null,
  f_Fin date not null,
  cargo varchar(100)not null,
  empresa varchar(100)not null,
  certificado varchar (100)not null,
  foreign key (id) references UsuarioDocente(id)
);
--TODO: Crear tabla de los cursos disponible
create table Cursos
(
  idCurso int identity primary key,
  curso varchar (100),
);
--TODO: Crear tabla de los cursos que dictara el docente
--NOTE: Esta tabla tiene dependencia de UsuarioDocente y Cursos
create table CursoDictado
(
  idCurso int not null,
  id int not null,
  foreign key (id) references UsuarioDocente(id),
  foreign key (idCurso) references Cursos(idCurso)
);
