## Presentacion
[Presentación Canvas](https://www.canva.com/design/DAGjh6u3p48/rKI2W-ZC5spZiHLZlqg7UQ/edit?utm_content=DAGjh6u3p48&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)
## Preguntas Teoricas
### ¿Qué son los principios SOLID y cómo contribuyen a un buen diseño orientado a objetos?
Los principios SOLID son un conjunto de cinco directrices que ayudan a diseñar sistemas orientados a objetos robustos, mantenibles y escalables. Cada principio aborda un aspecto distinto del diseño, promoviendo la calidad y la flexibilidad del software.

S - Single Responsibility Principle (Principio de Responsabilidad Única):
Cada clase debe tener una única razón para cambiar, es decir, estar enfocada en una sola responsabilidad o funcionalidad. Esto facilita la comprensión, mantenimiento y extensión de la clase.

O - Open/Closed Principle (Principio de Abierto/Cerrado):
Los módulos, clases o funciones deben estar abiertos para su extensión, pero cerrados para su modificación. Esto permite añadir nuevas funcionalidades sin alterar el código existente, reduciendo el riesgo de introducir errores.

L - Liskov Substitution Principle (Principio de Sustitución de Liskov):
Los objetos de una clase derivada deben poder sustituir a los objetos de la clase base sin afectar el comportamiento correcto del programa. Este principio asegura que la herencia se utilice de forma que no se altere la integridad del sistema.

I - Interface Segregation Principle (Principio de Segregación de Interfaces):
Es preferible tener varias interfaces específicas y pequeñas en lugar de una única interfaz general. De esta forma, las clases sólo implementan los métodos que realmente necesitan, lo que mejora la cohesión y reduce el acoplamiento.
D - Dependency Inversion Principle (Principio de Inversión de Dependencias):
Las clases de alto nivel no deben depender directamente de clases de bajo nivel; ambas deben depender de abstracciones (por ejemplo, interfaces o clases abstractas). Esto favorece la modularidad y facilita el cambio de implementaciones sin afectar al sistema en general.

### Explica cómo el patrón Singleton asegura que solo haya una instancia de una clase y cuáles son sus posibles usos.
Constructor privado o protegido:
La clase define un constructor privado (o protegido) para que ninguna otra clase pueda crear una instancia directamente con el operador new o mediante llamadas al constructor.

Instancia estática interna:
Se declara una variable estática que contendrá la única instancia de la clase. Esta variable es común para todas las instancias y, al ser privada, impide que se modifique desde fuera de la clase.

Método de acceso público:
Se implementa un método público (por lo general llamado getInstance() o similar) que devuelve la instancia única. Este método comprueba si la instancia ya existe; si no es así, la crea. De este modo, cada vez que se solicita la instancia, se devuelve la misma.

Sincronización (en entornos multihilo):
En aplicaciones concurrentes, se deben tomar precauciones adicionales para evitar la creación de múltiples instancias en diferentes hilos. Esto se logra usando mecanismos de sincronización, como el bloqueo (mutex) o el uso de inicialización temprana (eager initialization).

Posibles usos del patrón Singleton
Registro de logs (Logging):
Permite centralizar la escritura de logs en una única instancia, lo que facilita el seguimiento de eventos y errores en la aplicación.

Gestión de la configuración:
Un Singleton puede almacenar la configuración de la aplicación (parámetros, ajustes, etc.) de forma global, asegurando que todas las partes de la aplicación accedan a los mismos datos.

Pool de conexiones:
En aplicaciones que requieren acceso a bases de datos u otros recursos, un Singleton puede gestionar un pool de conexiones para optimizar el uso de recursos y garantizar la consistencia.

Control de acceso a recursos compartidos:
Se utiliza para gestionar el acceso a recursos críticos o compartidos, asegurando que solo un proceso o hilo pueda modificar el estado del recurso a la vez.

Interfaces de comunicación:
En aplicaciones que interactúan con sistemas externos (por ejemplo, un servicio web o un API), un Singleton puede actuar como punto central de comunicación, gestionando la conexión y evitando múltiples instancias innecesarias.
#### ¿Cómo contribuyen a un buen diseño orientado a objetos?
Mantenibilidad: Al tener responsabilidades claramente definidas, el código se vuelve más fácil de entender y modificar.

Extensibilidad: Permiten añadir nuevas funcionalidades sin modificar el código existente, reduciendo el riesgo de errores.

Reutilización: El desacoplamiento y la separación de responsabilidades favorecen la reutilización de componentes en diferentes contextos.

Facilidad de prueba: Un código bien estructurado y con dependencias invertidas es más fácil de aislar y probar mediante técnicas de pruebas unitarias.

### ¿Cómo funciona el patrón Observer?
El patrón Observer es un patrón de diseño de comportamiento que establece una relación de uno a muchos entre objetos. Cuando un objeto (el Sujeto, o Subject) cambia de estado, notifica automáticamente a todos los objetos que dependen de él (Observadores, o Observers).

1. El Sujeto mantiene una lista de observadores y provee métodos para añadir, eliminar y notificar a los observadores.

2. Los Observadores implementan una interfaz que define un método para recibir actualizaciones del Sujeto.

3. Cuando el estado del Sujeto cambia, este notifica a todos los Observadores, generalmente llamando a su método de actualización.

#### ¿En qué situaciones es útil?
Es útil cuando se necesita que varios objetos reaccionen automáticamente a cambios en otro objeto sin acoplarlos directamente. Se aplica en situaciones donde el estado de un objeto afecta a muchos otros, permitiendo una comunicación eficiente sin dependencias rígidas.

### ¿Qué es un antipatrón? explique por medio de dos ejemplos.
Es el contrario de las diferentes practicas que se han visto anteriormente en este documento, por ejmeplo con S.O.L.I.D. Por lo cual esta llega a ser una practica que se ve bien al inicio pero dentro de la pratica llega a ser poco efectivo o productivos, por ejemplo:
- Representar todo en un solo código, donde las variables, la lógica y los objetos se usen en un solo bloque extenso, puede generar problemas a largo plazo, causando descontrol en el código. Además, esto puede resultar en un código exageradamente largo y poco organizado
- Generar códigos extremadamente largos, donde las funciones o clases se entrecrucen de manera desordenada, dificulta la comprensión del código por parte del programador. Además, copiar y pegar fragmentos de código que funcionan en lugar de reutilizarlos adecuadamente para crear clases u objetos puede parecer una solución "fácil" a simple vista, pero a largo plazo complica el mantenimiento y genera problemas de escalabilidad.



