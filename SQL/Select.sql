use ProyectoFinal
exec sp_help Usuario_Docente

insert Usuario_Docente (nombreUsuario,contrase�a,nombre,apellidoPat,apellidoMat,dni,tipoDocumento,correoElectronico)
values ('Eduardo Quea','omarquea','Eduardo','Quea','Hancco',45128652,'DNI','omarquea@gmail.com')

select * from Usuario_Docente

exec sp_Login 'omarquea@gmail.com','omarquea'