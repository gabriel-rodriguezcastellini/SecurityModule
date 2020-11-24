create database Seguridad
go
use Seguridad
go
create table EstadosUsuarios(
	CodigoEstadoUsuario smallint primary key not null,
	euNombre varchar(25) not null,
	euDescripcion varchar(100) not null
)
go
create table EstadosGrupos(
	CodigoEstadoGrupo smallint primary key not null,
	egNombre varchar(25) not null,
	egDescripcion varchar(100) not null
)
go
create table Usuarios(	
	NombreUsuario varchar(25) primary key not null,
	usuClave varchar(50) not null,
	usuNombre varchar(50) not null,
	usuApellido varchar(50) not null,
	usuMail varchar(254) unique not null,
	usuEstadoUsuario smallint not null,
	foreign key (usuEstadoUsuario) references EstadosUsuarios(CodigoEstadoUsuario)
)
go
create table Grupos(
	CodigoGrupo varchar(15) primary key not null,
	gruDescripcion varchar(50) not null,
	gruEstado smallint not null,
	foreign key (gruEstado) references EstadosGrupos(CodigoEstadoGrupo)
)
go
create table Modulos(
	CodigoModulo varchar(15) primary key not null,
	modNombre varchar(25) not null,
	modDescripcion varchar(100) not null,
	modCodigoModuloPadre varchar(15) null,
	foreign key (modCodigoModuloPadre) references Modulos(CodigoModulo)
)
go
create table Formularios(
	CodigoFormulario varchar(15) primary key not null,
	forNombre varchar(25) not null,
	forDescripcion varchar(100) not null,
	forCodigoModulo varchar(15) not null,
	foreign key (forCodigoModulo) references Modulos(CodigoModulo)
)
go
create table Acciones(
	CodigoAccion varchar(15) primary key not null,
	accNombre varchar(25) not null,
	accDescripcion varchar(100) not null,
	accCodigoFormulario varchar(15) not null,
	foreign key (accCodigoFormulario) references Formularios(CodigoFormulario)
)
go
create table UsuariosGrupos(
	ugNombreUsuario varchar(25) not null,
	ugCodigoGrupo varchar(15) not null,
	primary key (ugNombreUsuario, ugCodigoGrupo),
	foreign key (ugNombreUsuario) references Usuarios(NombreUsuario),
	foreign key (ugCodigoGrupo) references Grupos(CodigoGrupo)
)
go
create table GruposAcciones(
	gaCodigoGrupo varchar(15) not null,
	gaCodigoAccion varchar(15) not null,
	primary key (gaCodigoGrupo, gaCodigoAccion),
	foreign key (gaCodigoGrupo) references Grupos(CodigoGrupo),
	foreign key (gaCodigoAccion) references Acciones(CodigoAccion),
)
print 'Base de datos creada.'