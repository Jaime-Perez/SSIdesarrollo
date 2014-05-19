CREATE TABLE tdeEspecificaciones(
    fcContratacion     DATETIME,
    txObservaciones    VARCHAR(10),
    txCarne            VARCHAR(10),
    idTipoEspec        INT            NOT NULL,
    idPersona          CHAR(10)       NOT NULL,
    idEstadoEspec      INT            NOT NULL,
    PRIMARY KEY (idTipoEspec, idPersona)
)ENGINE=MYISAM
;


CREATE TABLE tdeRol(
    idRolDetalle    INT            AUTO_INCREMENT,
    txRolDetalle    VARCHAR(30),
    idPermiso       INT            NOT NULL,
    idRol           INT            NOT NULL,
    PRIMARY KEY (idRolDetalle)
)ENGINE=MYISAM
;

CREATE TABLE tmaEstadoEspec(
    idEstadoEspec    INT            NOT NULL,
    txEstadoEspec    VARCHAR(40),
    PRIMARY KEY (idEstadoEspec)
)ENGINE=MYISAM
;


CREATE TABLE tmaEstadoUsuario(
    idEstadoUsuario    INT          AUTO_INCREMENT,
    txEstadoUsuario    VARCHAR(10),
    PRIMARY KEY (idEstadoUsuario)
)ENGINE=MYISAM
;


CREATE TABLE tmaPersona(
    idPersona              INT       AUTO_INCREMENT,
    txNombre               VARCHAR(20)    NOT NULL,
    txApellido             VARCHAR(20)    NOT NULL,
    fcNacimiento           TIME,
    txNit                  VARCHAR(20),
    txCorreoElectronico    VARCHAR(75)    NOT NULL,
    txTelefono             VARCHAR(30),
    txCelular              VARCHAR(75),
    fcIngresoPersona       DATETIME       NOT NULL,
    txSexo                 VARCHAR(15),
    txEstadoPersona        VARCHAR(30),
    direccion              VARCHAR(50),
    PRIMARY KEY (idPersona)
)ENGINE=MYISAM
;


CREATE TABLE tmaRol(
    idRol               INT             AUTO_INCREMENT,
    txRol               VARCHAR(30)     NOT NULL,
    txDescripcionRol    VARCHAR(100),
    PRIMARY KEY (idRol)
)ENGINE=MYISAM
;


CREATE TABLE tmaTipoEspec(
    idTipoEspec    INT            AUTO_INCREMENT,
    txTipoEspec    VARCHAR(40),
    PRIMARY KEY (idTipoEspec)
)ENGINE=MYISAM
;


CREATE TABLE tmaTipoUsuario(
    idTipoUsuario    INT            AUTO_INCREMENT,
    txTipoUsuario    VARCHAR(10),
    idRol            INT            NOT NULL,
    PRIMARY KEY (idTipoUsuario)
)ENGINE=MYISAM
;


CREATE TABLE tmaUsuario(
    idUsuario          INT            AUTO_INCREMENT,
    txUsuario          VARCHAR(25)    NOT NULL,
    txContrasena       VARCHAR(25),
    boNoticias         BIT(1),
    idTipoUsuario      INT            NOT NULL,
    idEstadoUsuario    INT            NOT NULL,
    idPersona          CHAR(10)       NOT NULL,
    PRIMARY KEY (idUsuario)
)ENGINE=MYISAM
;


ALTER TABLE tdeEspecificaciones ADD CONSTRAINT ReftmaTipoEspec58 
    FOREIGN KEY (idTipoEspec)
    REFERENCES tmaTipoEspec(idTipoEspec)
;

ALTER TABLE tdeEspecificaciones ADD CONSTRAINT ReftmaPersona59 
    FOREIGN KEY (idPersona)
    REFERENCES tmaPersona(idPersona)
;

ALTER TABLE tdeEspecificaciones ADD CONSTRAINT ReftmaEstadoEspec60 
    FOREIGN KEY (idEstadoEspec)
    REFERENCES tmaEstadoEspec(idEstadoEspec)
;

ALTER TABLE tdeRol ADD CONSTRAINT ReftmaRol18 
    FOREIGN KEY (idRol)
    REFERENCES tmaRol(idRol)
;



ALTER TABLE tmaTipoUsuario ADD CONSTRAINT ReftmaRol17 
    FOREIGN KEY (idRol)
    REFERENCES tmaRol(idRol)
;



ALTER TABLE tmaUsuario ADD CONSTRAINT ReftmaTipoUsuario7 
    FOREIGN KEY (idTipoUsuario)
    REFERENCES tmaTipoUsuario(idTipoUsuario)
;

ALTER TABLE tmaUsuario ADD CONSTRAINT ReftmaEstadoUsuario12 
    FOREIGN KEY (idEstadoUsuario)
    REFERENCES tmaEstadoUsuario(idEstadoUsuario)
;

ALTER TABLE tmaUsuario ADD CONSTRAINT ReftmaPersona16 
    FOREIGN KEY (idPersona)
    REFERENCES tmaPersona(idPersona)
;
