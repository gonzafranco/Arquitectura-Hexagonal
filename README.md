# Trabajo Práctico Integrador - Arquitectura Hexagonal

## Integrantes
- *Alejandro Salcedo*
- *Cristian Mazza*
- *Priscila Krutzinna*
- *Franco Gonzalez*

## Descripción
En este trabajo se implementa lo visto en la materia Laboratorio de Software.

Este proyecto cumple con los siguientes requisitos:

1. Desarrollo de una arquitectura de software aplicando los conceptos de DDD y arquitecturas limpias.
2. Implementación completa de un CRUD de una entidad.
3. Uso de inyección de dependencias.
4. Realización de pruebas unitarias.
5. Interacción con bases de datos de diferentes tipos.

## Instrucciones de despliegue

### Base de datos SQL (PosgreSQL)

#### Utilizando Docker

Dentro de la carpeta **docker** y el subdirectorio llamado [Posgres - Pgadmin4](https://github.com/gonzafranco/Arquitectura-Hexagonal/tree/main/Docker/Posgres-Pgadmin4), se encuentra el archivo **docker-compose.yml** con la configuración necesaria para levantar PostgreSQL y Pgadmin4.

Para levantar los contenedores, ejecuta el comando **docker-compose up**.

El código está preparado para funcionar automáticamente si se utiliza esta opción.

#### De manera local

Debes instalar al menos PostgreSQL Server.

Debes crear manualmente una base de datos llamada "Libros" con una tabla llamada "libros". Puedes utilizar el archivo **init.sql** para crear la tabla.

Debes cumplir con los pasos mencionados anteriormente para que el código funcione correctamente. Además, debes modificar el string de conexión [(_connectionString)](https://github.com/gonzafranco/Arquitectura-Hexagonal/blob/main/03-Infraestructura/LibroRepositorioPostgres.cs) ya que actualmente se está utilizando un puerto que no es el predeterminado.

### Base de datos NoSQL (MongoDB)

#### Utilizando Docker

Dentro de la carpeta **docker** y el subdirectorio llamado [MongoDB](https://github.com/gonzafranco/Arquitectura-Hexagonal/tree/main/Docker/MongoDb), se encuentra el archivo **docker-compose.yml** con la configuración necesaria para levantar MongoDB.

Para levantar los contenedores, ejecuta el comando **docker-compose up**.

Debes crear previamente una base de datos llamada "Libros" y asignar una colección llamada "Libros".

#### De manera local

Debes tener MongoDB instalado en tu máquina.

Debes crear previamente una base de datos llamada "Libros" y asignar una colección llamada "Libros".

Debes modificar el parámetro [client](https://github.com/gonzafranco/Arquitectura-Hexagonal/blob/main/03-Infraestructura/LibroRepositorioMongo.cs) ya que se está utilizando un puerto que no es el predeterminado.
