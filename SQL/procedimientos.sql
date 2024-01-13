use ProyectoFinal

--TODO: Seccion del login

--NOTE: agregar usuario
create proc sp_AgregarUsuario
  @nombre varchar(50),
  @apeP varchar(50),
  @apeM varchar(50),
  @username varchar(50),
  @tipo varchar(2),
  @doc varchar(12),
  @correo varchar(50),
  @contra varchar(50)
as
insert UsuarioDocente
  (nombre,apeP,apeM,username,tipo,doc,correo,contra,registrado)
values
  (@nombre, @apeP, @apeM, @username, convert(int,@tipo), convert(bigint,@doc), @correo, ENCRYPTBYPASSPHRASE('password',@contra), 0)
go

--NOTE: valiar si el usuario existe
create proc sp_ValidarUsuario
  @doc int,
  @correo varchar(50)
as
select nombre
from UsuarioDocente
where doc=@doc or correo=@correo;
go

--NOTE: validar correo y contraseña para ingresar
create proc sp_Login
  @correo varchar(50),
  @contra varchar(50)
as
select id
from UsuarioDocente
where correo=@correo and DECRYPTBYPASSPHRASE('password',contra)=@contra;
go

create proc sp_L_password
  @correo varchar(50)
as
if exists(select 1
from UsuarioDocente
where correo=@correo)
	begin
  select
    CONVERT(varchar(50), DECRYPTBYPASSPHRASE('password', contra)) AS DatosDesencriptados
  FROM UsuarioDocente
  where correo=@correo;
end
-------------------------------------------------------------------------

--TODO: Seccion del inicio

--NOTE: listar datos del usuario
create proc sp_I_listarUsuario
  @id int
as
select username, nombre, apeP, apeM, tipo, doc, correo
from UsuarioDocente
where id=@id
go

--NOTE: listar datos adicionales del usuario
create proc sp_I_listarDatosExtras
  @id int
as
begin
  set nocount on;
  if exists ( select 1
  from RegistroDocente
  where id = @id )
    select s.tipo as sexo, e.estado as estadoCivil, direccion, telefono,
    celular, rd.ubigeo, dpto, prov, distrito, foto, fNacimiento,
    precio_Hora
  from RegistroDocente rd inner join
    Ubigeo u on rd.ubigeo=u.ubigeo inner join
    Sexo s on rd.sexo=s.id inner join
    EstadoCivil e on rd.estadoCivil=e.id
  where rd.id=10
end

--NOTE: listar datos academicos del usuario
create proc sp_I_listarDatosAcademicos
  @id int
as
select id, idDatos, titulo, centroEstudios, fechaGrado, subirTitulo
from DatosAcademicos
where id=@id
go

--NOTE: listar experencias del usuario
create proc sp_I_listarExperiencias
  @id int
as
select id, idExpe, cargo, empresa, f_Inicio, f_Fin, certificado
from Experencias
where id=@id
go

--NOTE: listar cursos que dictara el usuario
create proc sp_I_listarCursosDictados
  @id int
as
select curso
from Cursos c
  inner join CursoDictado cd on c.idCurso=cd.idCurso
  inner join UsuarioDocente ud on cd.id=ud.id
where ud.id=@id
go

create proc sp_I_listarDiscapacidades
  @id int
as
select *
from Discapacidad
where id=@id

create proc sp_registro
  @id int
as
update UsuarioDocente
  set registrado = 1
  where id=@id

-------------------------------------------------------------------------

--TODO: Seccion del datos adicionales

--NOTE: registrar datos ( ingresar o actualizar )
create proc sp_R_ingresarDatos
  @id int,
  @sex varchar(20),
  @civil varchar(20),
  @direc varchar(50),
  @ubigeo varchar(6),
  @telefono varchar(20),
  @celular varchar(20),
  @foto varchar(50),
  @fNac date,
  @precio decimal
as
begin
  select *
  from RegistroDocente
  where id=@id
  if @@ROWCOUNT > 0
  begin
    update RegistroDocente
    set
    sexo = @sex,
    estadoCivil = @civil,
    direccion = @direc,
	  ubigeo = @ubigeo,
    telefono = @telefono,
    celular = @celular,
    foto = @foto,
    fNacimiento = @fNac,
    fModficacion = getdate(),
    precio_Hora = @precio
    where id=@id
  end;
  else
  begin
    insert RegistroDocente
      (id,sexo,estadoCivil,direccion,ubigeo,telefono,celular,foto,fNacimiento,fRegistro,fModficacion,precio_Hora)
    values
      (@id, @sex, @civil, @direc, @ubigeo, @telefono, @celular, @foto, @fNac, getdate(), getdate(), @precio)
  end
end
GO

create proc sp_R_obtenerUbigeo
  @dpto varchar(30),
  @prov varchar(30),
  @dist varchar(30)
as
select ubigeo
from Ubigeo
where dpto=@dpto and prov=@prov and distrito=@dist

create proc sp_R_actualizarDatosUsuario
  @id int,
  @username nvarchar(50),
  @correo nvarchar(50),
  @nombre nvarchar(50),
  @apeP nvarchar(50),
  @apeM nvarchar(50),
  @tipo varchar(2),
  @doc varchar(12)
as
update UsuarioDocente
  set username=@username,
  correo=@correo,
  nombre=@nombre,
  apeP=@apeP,
  apeM=@apeM,
  tipo=convert(int,@tipo),
  doc=convert(bigint,@doc)
  where id=@id
go

create proc sp_R_newPassword
  @id int,
  @contra varchar(10),
  @new varchar(10)
as
update UsuarioDocente
  set contra=ENCRYPTBYPASSPHRASE('password',@new)
  where DECRYPTBYPASSPHRASE('password',contra)=@contra and id=@id

-------------------------------------------------------------------------

--TODO: Seccion del discapacidades

--NOTE: agregar discapacidades
create proc sp_R_agregarDiscapacidad
  @id int,
  @nombre varchar(50),
  @descripcion text
as
insert Discapacidad
  (id,discapacidad,descDiscapacidad)
values
  (@id, @nombre, @descripcion)

--NOTE: eliminar discapacidades
create proc sp_R_eliminarDiscapacidad
  @id int,
  @idD int
as
delete from Discapacidad
  where id=@id and idDiscapacidad=@idD

--NOTE: actualizar discapacidades
create proc sp_R_actualizarDiscapacidad
  @id int,
  @idD int,
  @dis varchar(50),
  @descrip text
as
update Discapacidad
  set discapacidad=@dis,
  descDiscapacidad=@descrip
  where id=@id and idDiscapacidad=@idD

--NOTE: obtener discapacidades
create proc sp_R_obtenerDiscapacidad
  @id int,
  @idD int
as
select *
from Discapacidad
where id=@id and idDiscapacidad=@idD

-------------------------------------------------------------------------
--TODO: listando Ubigeo
create proc sp_listarDpto
as
select dpto
from Ubigeo
group by dpto

create proc sp_listarProv
  @dpto varchar(30)
as
select prov
from Ubigeo
where dpto=@dpto
group by prov

create proc sp_listarDist
  @dpto varchar(30),
  @prov varchar(30)
as
select distrito
from Ubigeo
where dpto=@dpto and prov=@prov
group by distrito

-------------------------------------------------------------------------
--TODO: procedimientos de datos academicos
create proc sp_A_agregarDatos
  @id int,
  @titulo varchar(100),
  @insti varchar(100),
  @fecha date,
  @pdf varchar(50)
as
insert DatosAcademicos
  (id,titulo,centroEstudios,fechaGrado,subirTitulo)
values
  (@id, @titulo, @insti, @fecha, @pdf)

create proc sp_A_eliminarDatos
  @id int,
  @idA int
as
delete from DatosAcademicos
  where id=@id and idDatos=@idA
-------------------------------------------------------------------------
--TODO: procedimientos de experencias
create proc sp_E_agregarExperiencia
  @id int,
  @fI date,
  @fF date,
  @cargo varchar(50),
  @empresa varchar(100),
  @certi varchar(50)
as
insert Experencias
  (id,f_Inicio,f_Fin,cargo,empresa,certificado)
values
  (@id, @fI, @fF, @cargo, @empresa, @certi)

create proc sp_E_eliminarExperiencia
  @id int,
  @cargo varchar(100),
  @emp varchar(100)
as
delete from Experencias
  where id=@id and cargo=@cargo and empresa=@emp
-------------------------------------------------------------------------
--TODO: procedimientos de cursos
create proc sp_C_addCursoD
  @id int,
  @idC int
as
begin
  if not exists(select 1
  from CursoDictado
  where id=@id and idCurso=@idC)
	begin
    declare @cant int
    select @cant=COUNT(*)
    from CursoDictado
    where id=@id

    if @cant<5
		begin
      insert into CursoDictado
        (id,idCurso)
      values(@id, @idC)
    end
  end
end

--TODO: listar cursos
create proc sp_C_listarCursos
  @id int
as
select c.idCurso, c.curso
from Cursos c
  left join CursoDictado cd
  on c.idCurso=cd.idCurso and cd.id=@id
where cd.idCurso is null;

--TODO: obtener curso
create proc sp_C_obtenerCurso
  @idC int
as
select curso
from Cursos
where idCurso=@idC

--TODO: obtener experiencia
create proc sp_E_obtener
  @id int,
  @idE int
as
select *
from Experencias
where id=@id and idExpe=@idE

--TODO: actulizar experiencia
create proc sp_E_actualizar
  @id int,
  @idE int,
  @fi varchar(15),
  @ff varchar(15),
  @cargo varchar(50),
  @emp varchar(100),
  @certi varchar(50)
as
update Experencias
    set f_Inicio=@fi,f_Fin=@ff,cargo=@cargo,
    empresa=@emp,certificado=@certi
    where id=@id and idExpe=@idE

--TODO:obtener datos academicos
create proc sp_A_obtener
  @id int,
  @idA int
as
select *
from DatosAcademicos
where id=@id and idDatos=@idA

--TODO:actulizar datos academicos
create proc sp_A_actualizar
  @id int,
  @idA int,
  @fg varchar(15),
  @centro varchar(100),
  @titulo varchar(100),
  @pdf varchar(100)
as
update DatosAcademicos
    set fechaGrado=@fg ,centroEstudios=centroEstudios ,
    titulo=@titulo ,subirTitulo=@pdf
    where id=@id and idDatos=@idA

--TODO:verificar documento y correo no sean iguales
create proc sp_R_verificarData
  @doc varchar(10),
  @correo varchar(50)
as
select *
from UsuarioDocente
where doc=convert(bigint,@doc) or correo=@correo