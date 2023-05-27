# Ejercicio 4
¿String es una tipo por valor o un tipo por referencia?

Es un tipo por referencia
---------------------
¿Qué secuencias de escape tiene el tipo string?

Secuencia	Significado
\a	        Emite un pitido
\b	        Retroceso (permite borrar el �ltimo car�cter)
\f	        Avance de página (expulsa una hoja en la impresora)
\n	        Avanza de línea (salta a la línea siguiente)
\r	        Retorno de carro (va al principio de la línea)
\t	        Salto de tabulación horizontal
\v	        Salto de tabulación vertical
\'	        Muestra una comilla simple
\"	        Muestra una comilla doble
\\	        Muestra una barra invertida
\0	        Carácter nulo (NULL)
-------------------------

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

@
En algunas ocasiones puede ser incómodo manipular estas secuencias de escape. Por ejemplo, cuando usemos estructuras de directorios: c:\\datos\\ejemplos\\curso\\ejemplo1. En este caso, se puede usar una arroba (@) antes del texto sin las barras invertidas:
ruta = @"c:\datos\ejemplos\curso\ejemplo1"

En este caso, el problema está si aparecen comillas en medio de la cadena. Para solucionarlo, se duplican las comillas, así:
orden = @"copy ""documento de ejemplo"" f:"

$
var name = "<name>";
Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

El argumento de cadena de la llamada al método WriteLine es una expresión de cadena interpolada. Es un tipo de plantilla que permite construir una sola cadena (denominada cadena de resultado) a partir de una cadena que incluye código incrustado. Las expresiones de cadena interpoladas son especialmente útiles para insertar valores en una cadena o para concatenar (unir entre sí) varias cadenas.

El ejemplo anterior contiene los dos elementos que debe tener toda expresión de cadena interpolada:

Un literal de cadena que empieza con el carácter $ antes del carácter de comillas de apertura. No puede haber ningún espacio entre el símbolo $ y el carácter de comillas. (Si quiere ver qué ocurre si incluye uno, inserte un espacio después del carácter $ en la ventana interactiva y ejecute el código actualizado. El compilador de C# notifica el error "Carácter '$' no esperado").

Una o varias expresiones de interpolación. Una expresión de interpolación se indica mediante una llave de apertura y de cierre ({ y }). Puede colocar cualquier expresión de C# que devuelva un valor (incluido null) dentro de las llaves.