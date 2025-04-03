## Presentacion
[Presentación Canvas](https://www.canva.com/design/DAGjh6u3p48/rKI2W-ZC5spZiHLZlqg7UQ/edit?utm_content=DAGjh6u3p48&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)
## Preguntas Teoricas
## ¿Qué son los principios SOLID y cómo contribuyen a un buen diseño orientado a objetos?
Los principios SOLID son un conjunto de cinco directrices que ayudan a diseñar sistemas orientados a objetos robustos, mantenibles y escalables. Cada principio aborda un aspecto distinto del diseño, promoviendo la calidad y la flexibilidad del software. A continuación, se describen brevemente:

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

### ¿cómo contribuyen a un buen diseño orientado a objetos?
Mantenibilidad: Al tener responsabilidades claramente definidas, el código se vuelve más fácil de entender y modificar.

Extensibilidad: Permiten añadir nuevas funcionalidades sin modificar el código existente, reduciendo el riesgo de errores.

Reutilización: El desacoplamiento y la separación de responsabilidades favorecen la reutilización de componentes en diferentes contextos.

Facilidad de prueba: Un código bien estructurado y con dependencias invertidas es más fácil de aislar y probar mediante técnicas de pruebas unitarias.

## ¿Cómo funciona el patrón Observer?
El patrón Observer es un patrón de diseño de comportamiento que establece una relación de uno a muchos entre objetos. Cuando un objeto (el Sujeto, o Subject) cambia de estado, notifica automáticamente a todos los objetos que dependen de él (Observadores, o Observers).

!. El Sujeto mantiene una lista de observadores y provee métodos para añadir, eliminar y notificar a los observadores.
####
2. Los Observadores implementan una interfaz que define un método para recibir actualizaciones del Sujeto.
####
3. Cuando el estado del Sujeto cambia, este notifica a todos los Observadores, generalmente llamando a su método de actualización.
 ####
 ## ¿En qué situaciones es útil?
Es útil cuando se necesita que varios objetos reaccionen automáticamente a cambios en otro objeto sin acoplarlos directamente. Se aplica en situaciones donde el estado de un objeto afecta a muchos otros, permitiendo una comunicación eficiente sin dependencias rígidas.

## ¿Qué son los principios SOLID y cómo contribuyen a un buen diseño orientado a objetos?
El patrón Singleton garantiza que una clase tenga una única instancia en todo el programa y proporciona un punto global de acceso a ella. Para lograr esto, sigue estos pasos clave:

Almacena una referencia estática a la única instancia:
Se usa una variable de clase (o atributo estático) para guardar la instancia única.

Controla la creación de instancias:
Se impide la creación directa de objetos restringiendo el constructor, generalmente haciéndolo privado (en lenguajes como Java o C#) o utilizando una verificación en Python.

Proporciona un método de acceso global:
Se define un método estático (o de clase) que devuelve siempre la misma instancia, creándola solo si no existe.

Evita problemas en entornos multihilo:
Se usan bloqueos o enfoques de inicialización segura para evitar que múltiples hilos creen instancias duplicadas.

### posibles usos 
Registro de logs (Logging):
Un Singleton puede centralizar el registro de mensajes, evitando que se creen múltiples instancias que intenten escribir simultáneamente en el mismo archivo o medio.

Gestión de la configuración:
Permite mantener una única instancia de la configuración de la aplicación, garantizando que todos los componentes accedan a la misma información.

Conexión a bases de datos:
Ayuda a administrar las conexiones a la base de datos para evitar la creación innecesaria de múltiples conexiones, lo que puede ser costoso en términos de recursos.

Gestión de recursos compartidos:
Puede usarse para administrar recursos críticos (como un pool de conexiones o un cache) que deben ser accedidos de manera coordinada en toda la aplicación.

Control de acceso a dispositivos o servicios del sistema:
Por ejemplo, en aplicaciones que requieren coordinación centralizada para interactuar con hardware o servicios externos, un Singleton garantiza que se mantenga un único punto de control.

### ¿Cómo funciona el patrón Observer y en qué situaciones es útil?
es un patrón de diseño de comportamiento que define una relación de uno a muchos entre objetos. Esto significa que cuando un objeto (llamado sujeto o observable) cambia su estado, notifica automáticamente a todos los objetos que dependen de él (los observadores), permitiendo que se actualicen de forma coherente.
