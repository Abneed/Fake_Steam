--------------------PROCEDIMIENTO AGREGAR A ESTADO-----------------------------------------------------
CREATE PROCEDURE AGREGAR_ESTADO @NOMBRE VARCHAR(25),@ABREVIATURA VARCHAR(5) AS
INSERT INTO ESTADO(NOMBRE,ABREVIATURA) VALUES (UPPER(@NOMBRE),UPPER(@ABREVIATURA))
------------------------VALIDACION-----------------------------------------------------
CREATE TRIGGER AGREGARESTADO ON ESTADO 
FOR INSERT,UPDATE 
AS
IF(EXISTS(SELECT ES.NOMBRE 
          FROM   inserted AS ES 
          GROUP BY ES.NOMBRE
          HAVING  1 < ANY           (SELECT COUNT(*)
		                             FROM ESTADO AS EST
									WHERE ES.NOMBRE=NOMBRE 
									 GROUP BY EST.NOMBRE
									 )
	     
		  			        )  )
  BEGIN
    ROLLBACK TRAN
    RAISERROR('EL ESTADO YA EXISTE DENTRO DE LA BASE DE DATOS', 16, 1)
  END
-----------------------------------CAMPO DE PRUEBA-------------------------------------------------------
EXEC AGREGAR_ESTADO 'CAMPECHE','Camp'
EXEC AGREGAR_ESTADO 'Chiapas','CHP'
EXEC AGREGAR_ESTADO 'TAMAULIPAS','TAM'
EXEC AGREGAR_ESTADO 'NUEVO LEON','NLE'
--------------------------------PROCEDIMIENTO AGREGAR CIUDAD-*--------+-------------
CREATE PROCEDURE AGREGAR_CIUDAD @NOMBRE VARCHAR(25) AS

INSERT INTO CIUDAD(NOMBRE) VALUES (UPPER(@NOMBRE))
-------------------------------VALIDACION--------------------------------------
CREATE TRIGGER AGREGARCIUDAD ON CIUDAD 
FOR INSERT,UPDATE 
AS
IF(EXISTS(SELECT ES.NOMBRE 
          FROM   inserted AS ES 
          GROUP BY ES.NOMBRE
          HAVING  1 < ANY           (SELECT COUNT(*)
		                             FROM CIUDAD AS EST
									WHERE ES.NOMBRE=NOMBRE 
									 GROUP BY EST.NOMBRE
									 )
	     
		  			        )  )
  BEGIN
    ROLLBACK TRAN
    RAISERROR('LA CIUDAD YA EXISTE EN LA BASE DE DATOS', 16, 1)
  END
 ---------------------------EJEMPLO--------------
 EXEC AGREGAR_CIUDAD 'NUEVO LAREDO'
----------------------------------AGREGAR PAIS--------------------
CREATE PROCEDURE AGREGAR_PAIS @NOMBRE VARCHAR(25) AS
INSERT INTO PAIS(NOMBRE) VALUES (UPPER(@NOMBRE))
-------------------------------VALIDACION--------------------------------------
CREATE TRIGGER AGREGARPAIS ON PAIS
FOR INSERT,UPDATE 
AS
IF(EXISTS(SELECT ES.NOMBRE 
          FROM   inserted AS ES 
          GROUP BY ES.NOMBRE
          HAVING  1 < ANY           (SELECT COUNT(*)
		                             FROM PAIS AS EST
									WHERE ES.NOMBRE=NOMBRE 
									 GROUP BY EST.NOMBRE
									 )
	     
		  			        )  )
  BEGIN
    ROLLBACK TRAN
    RAISERROR('EL PAIS YA EXISTE EN LA BASE DE DATOS', 16, 1)
  END 

