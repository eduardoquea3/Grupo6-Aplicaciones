use ProyectoFinal

--TODO: Seccion del login

--NOTE: agregar usuario
create proc sp_AgregarUsuario
	@nombre varchar(50),
	@apeP varchar(50),
	@apeM varchar(50),
	@username varchar(50),
	@tipo varchar(50),
	@doc int,
	@correo varchar(50),
	@contra varchar(50)
as
  insert Usuario_Docente
  (nombre,apeP,apeM,username,tipo,doc,correo,contra)
	values
	(@nombre,@apeP,@apeM,@username,@tipo,@doc,@correo,@contra)
go

--NOTE: valiar si el usuario existe
create proc sp_ValidarUsuario
	@doc int,
	@correo varchar(50)
as
  select nombre
  from Usuario_Docente
  where doc=@doc or correo=@correo;
go

--NOTE: validar correo y contraseña para ingresar
create proc sp_Login
	@correo varchar(50),
	@contra varchar(50)
as
  select id
  from Usuario_Docente
  where correo=@correo and contra=@contra;
go

-------------------------------------------------------------------------

--TODO: Seccion del inicio

--NOTE: listar datos del usuario
create proc sp_I_listarUsuario
  @id int
as
  select username,nombre,apeP,apeM,tipo,doc,correo from Usuario_Docente
  where id=@id
go

--NOTE: listar datos adicionales del usuario
create proc sp_I_listarDatosExtras
  @id int
as
begin
  set nocount on;
  if exists ( select 1 from RegistroDocente where id = @id )
    select sexo,estadoCivil,direccion,telefono,
    celular,rd.ubigeo,dpto,prov,distrito,foto,fNacimiento
    precio_Hora
    from RegistroDocente rd inner join
    Ubigeo u on rd.ubigeo=u.ubigeo
    where id=@id
end

--NOTE: listar datos academicos del usuario
create proc sp_I_listarDatosAcademicos
  @id int
as
  select titulo,centroEstudios,fechaGrado
  from DatosAcademicos
  where id=@id
go

--NOTE: listar experencias del usuario
create proc sp_I_listarExperiencias
  @id int
as
  select cargo,empresa,f_Inicio,f_Fin from Experencias
  where id=@id
go

--NOTE: listar cursos
create proc sp_I_listarCursos
as
  select curso from Cursos
go

--NOTE: listar cursos que dictara el usuario
create proc sp_I_listarCursosDictados
  @id int
as
  select curso
  from Cursos c
  inner join Curso_Dictado cd on c.idCurso=cd.idCurso
  inner join Usuario_Docente ud on cd.id=ud.id
  where ud.id=@id
go

-------------------------------------------------------------------------

--TODO: Seccion del datos adicionales

--NOTE: registrar datos ( ingresar o actualizar )
create proc sp_R_ingresarDatos
  @id int,@sexo nvarchar(20),@civil nvarchar(20),
  @direc nvarchar(50),@ubigeo varchar(6),@telefono nvarchar(20),@celular nvarchar(20),
  @foto nvarchar(200),@fNacimiento date,@precio decimal(10,2)
as
begin
  select * from RegistroDocente
  where id=@id
  if @@ROWCOUNT > 0
  begin
    update RegistroDocente
    set
    sexo = @sexo,
    estadoCivil = @civil,
    direccion = @direc,
    telefono = @telefono,
    celular = @celular,
    foto = @foto,
    fNacimiento = @fNacimiento,
    fModficacion = format(getdate(),'dd-MM-yyyy'),
    precio_Hora = @precio
    where id=@id
  end;
  else
  begin
  insert RegistroDocente (id,sexo,estadoCivil,direccion,ubigeo,telefono,celular,foto,fNacimiento,fRegistro,fModficacion,precio_Hora)
  values (@id,@sexo,@civil,@direc,@ubigeo,@telefono,@celular,@foto,@fNacimiento,format(getdate(),'dd-MM-yyyy'),format(getdate(),'dd-MM-yyyy'),@precio)
  end
end

create proc sp_R_actualizarDatosUsuario
  @id int,@username nvarchar(50),@correo nvarchar(50)
as
  update Usuario_Docente
  set username=@username,
  correo=@correo
  where id=@id
go

create proc sp_R_newPassword
  @id int,@contra nvarchar(10),@new nvarchar(10)
as
begin
  select * from Usuario_Docente
  where contra=@contra and id=@id
  if @@ROWCOUNT > 0
  begin
    update Usuario_Docente
    set contra=@new
    where contra=@contra and id=@id
    return 'Se realizo correctamente'
  end
  begin
    return 'No se realizo correctamente'
  end
end
