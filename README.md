# Trabajo Práctico Integrador -  Arquitectura Hexagonal

# Integrantes
- *Alejandro Salcedo*
- *Cristian Mazza*
- *Priscila Krutzinna*
- *Franco Gonzalez*



# Descripción
En este trabajo se implementa los visto en la materia Laboratorio de Software.


Este proyecto cumple con los siguientes requisitos:

1. Un desarrollo de una arquitectura de software aplicando los conceptos de DDD y arquitecturas limpias.
2. Un CRUD completo de una entidad.
3. Inyección de dependencias.
4. Pruebas Unitarias.
5. Intercambio entre bases de datos de distinto tipos.


# Instrucciones de despliegue

## Base de datos SQL (PosgreSql)

### Utilizando Docker

Dentro de la carpeta **docker** y el directorio llamado [Posgres - Pgadmin4](https://github.com/gonzafranco/Arquitectura-Hexagonal/tree/main/Docker/Posgres-Pgadmin4),  se encuentra el archivo **docker-compose.yml** con la configuración necesaria para levantar PosgreSql y Pgadmin4.

Para Levantar los contenedores se correr el comando **docker-compose up**

El codigo esta preparado para funcionar automáticamente si se utiliza esta opción.

### De manera local

Se debe instalar Por lo menos PosgreSql server.

Se necesita crear manualmente un base de datos llamada "Libros" con una tabla llamada "libros". Se puede utilizar el archivo **init.sql** para crear la tabla.

Se necesita cumplir con los pasos ya mencionados para que el codigo funcione correctamente. Tambien se debe modificar el string de conexion [(_connectionString )](https://github.com/gonzafranco/Arquitectura-Hexagonal/blob/main/03-Infraestructura/LibroRepositorioPostgres.cs), ya que se actualmente se esta utilizando un puerto que no es el por defecto.


## Base de datos SQL (MongoDB)

### Utilizando Docker

Dentro de la carpeta **docker** y el directorio llamado [MongoDB](https://github.com/gonzafranco/Arquitectura-Hexagonal/tree/main/Docker/MongoDb),  se encuentra el archivo **docker-compose.yml** con la configuración necesaria para levantar MongoDB.

Para Levantar los contenedores se correr el comando **docker-compose up**

Se necesita crear de antemano Una base de datos llamada "Libros" y asignar una colección llamada "Libros".


### De manera Local

Se debe contar con MongoDB ya instalado.

Se necesita crear de antemano Una base de datos llamada "Libros" y asignar una colección llamada "Libros".

Se debe de modificar el parametro de [client](https://github.com/gonzafranco/Arquitectura-Hexagonal/blob/main/03-Infraestructura/LibroRepositorioMongo.cs), ya que se esta utilizando un puerto que no es el por defecto.









