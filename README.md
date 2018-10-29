# ExamenEntityFramework
Proyecto de prueba del examen de Entity Framework del curso de .NET

## 1. Dadas las siguientes estructuras de datos:
## Genera el modelo de dominio. Como regla de negocio es necesario calcular el precio de la pizza multiplicando el precio de cada ingrediente por el 20% de beneficios.
Hemos creado las clases Pizza e Ingrediente que representarán los datos de la base de datos con estos mismos nombres. Se ha creado una propiedad tipo colección de pizzas en la clase Ingrediente para generar una relación ManyToMany con la clase Pizza y su colección de ingredientes.
También se ha creado una clase PizzeriaContext que representa el contexto de los objetos de la aplicación (pizzas e ingredientes).

## 2.Implementa el repostiroty pattern y el UnitofWork.
Hemos creado una interfaz que representa el repositorio de la pizzería en esta aplicación. Ésta define los métodos que permitirán leer, modificar, insertar, eliminar y salvar el estado de los registros en una base de datos externa. En la clase PizzeriaRepository implementamos los métodos de la interfaz que permiten estas acciones y, además, un método Dispose (implementando la interfaz IDisposable) para poder liberar recursos tras las transacciones con la base de datos.

## 3.El usuario nos solicita poder filtrar las pizzas por nombre y si no pone ningún nombre deben aparecer las primeras 15 pizzas, es decir necesitamos paginar las pizzas de 15 en 15 registros. Escribe una alternativa al specification pattern con linq.

## 4. Por último el usuario nos pide un cambio y es agregar la cantidad de un ingrediente en una pizza. Este atributo no puede tener un valor menor que uno y el cálculo del precio de la pizza se calculará multiplicando  la cantidad por el precio y agregando el 20% de beneficios. Este cambio y dado el tiempo transcurrido desde la implementación de la primera solución requiere la utilización de Migrations.