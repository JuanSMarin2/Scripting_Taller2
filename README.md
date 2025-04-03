## Presentacion
[Presentación Canvas](https://www.canva.com/design/DAGjh6u3p48/rKI2W-ZC5spZiHLZlqg7UQ/edit?utm_content=DAGjh6u3p48&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)
## Preguntas Teoricas
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

## ¿cómo contribuyen a un buen diseño orientado a objetos?
Mantenibilidad: Al tener responsabilidades claramente definidas, el código se vuelve más fácil de entender y modificar.

Extensibilidad: Permiten añadir nuevas funcionalidades sin modificar el código existente, reduciendo el riesgo de errores.

Reutilización: El desacoplamiento y la separación de responsabilidades favorecen la reutilización de componentes en diferentes contextos.

Facilidad de prueba: Un código bien estructurado y con dependencias invertidas es más fácil de aislar y probar mediante técnicas de pruebas unitarias.
