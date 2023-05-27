// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;
// int b;

// a=10;
// b=a;

// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);

// EJERCICIO 1

// int num=0;
// Console.WriteLine("Ingrese el numero que quiere invertir");
// string numero;

// numero = Console.ReadLine();

// bool control  = int.TryParse(numero,out num);
// //156
// int inversion=0;

// if (control)
// {
//     while (num != 0)
//     {
//         inversion = inversion*10 + num % 10;
//         num = num/10;
//     }
//     Console.WriteLine(inversion);
// } else
// {
//     Console.WriteLine("No ingreso un numero");
// }

// EJERCICIO 2

// int numero1, numero2, resultado, menu, opcionRepetir;
// string opcionIngresada;
// bool control;


// do
// {
//     Console.WriteLine("----- CALCULADORA -----");
//     Console.WriteLine("Ingrese la operacion que desea realizar: ");
//     Console.WriteLine("\t1 - Sumar");
//     Console.WriteLine("\t2 - Restar");
//     Console.WriteLine("\t3 - Multiplicar");
//     Console.WriteLine("\t4 - Dividir");

//     opcionIngresada = Console.ReadLine();
//     control = int.TryParse(opcionIngresada,out menu);

//     if (control)
//     {
//         switch (menu)
//         {
//             case 1:
//                 Console.WriteLine("Ingrese el primer numero a sumar: ");
//                 numero1 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Ingrese el segundo numero a sumar: ");
//                 numero2 = Convert.ToInt32(Console.ReadLine());
//                 resultado = numero1+numero2;
//                 Console.WriteLine($"La suma {numero1} y de {numero2} es igual a : {resultado}");
//                 break;
//             case 2:
//                 Console.WriteLine("Ingrese el primer numero al que se le va restar: ");
//                 numero1 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Ingrese el segundo numero que va restar al anterior: ");
//                 numero2 = Convert.ToInt32(Console.ReadLine());
//                 resultado = numero1-numero2;
//                 Console.WriteLine("El resultado es: "+ resultado);
//                 break;
//             case 3:
//                 Console.WriteLine("Ingrese el primer numero a multiplicar: ");
//                 numero1 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Ingrese el segundo numero a multiplicar: ");
//                 numero2 = Convert.ToInt32(Console.ReadLine());
//                 resultado = numero1*numero2;
//                 Console.WriteLine("El resultado es: "+ resultado);
//                 break;
//             case 4:
//                 Console.WriteLine("Ingrese el primer numero a dividir: ");
//                 numero1 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Ingrese el segundo numero que va dividir el anterior: ");
//                 numero2 = Convert.ToInt32(Console.ReadLine());
//                 resultado = numero1/numero2;
//                 Console.WriteLine("El resultado es: "+ resultado);
//                 break;
//             default:
//                 Console.WriteLine("Opcion ingresada incorrecta");
//                 break;
//         }
        
//     }else
//     {
//         Console.WriteLine("Opcion ingresada incorrecta");
//     }

//     Console.WriteLine("Desea realizar otra operacion? 1 - SI , 2 - NO : ");
//     opcionRepetir = Convert.ToInt32(Console.ReadLine());
// } while (opcionRepetir == 1);

// EJERCICIO 3
// int numero;
// float numeroFloat=1.2f;
// bool control1;

// Console.WriteLine("Ingrese un numero:");
// control1 = int.TryParse(Console.ReadLine(),out numero);

// if (control1)
// {
//     Console.WriteLine("El valor absoluto del numero es: "+ Math.Abs(numero));
//     Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero,2));
//     Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(numero));
//     Console.WriteLine("El seno del numero es: " + Math.Sin(numero));
//     Console.WriteLine("El coseno del numero es: " + Math.Cos(numero));
//     Console.WriteLine("La parte entero del numero es: " + Math.Truncate(numeroFloat));
// }else
// {
//     Console.WriteLine("Numero ingresado incorrecto");
// }

// int numero3, numero4, maximo, minimo;
// bool control2, control3;

// Console.WriteLine("Ingrese 2 numeros ");
// Console.WriteLine("1er numero:");
// control2 = int.TryParse(Console.ReadLine(),out numero3);
// if (control2)
// {
//     Console.WriteLine("2do numero:");
//     control3 = int.TryParse(Console.ReadLine(),out numero4);
//     if (control3)
//     {
//         maximo = Math.Max(numero3,numero4);
//         Console.WriteLine("El mayor de los numeros es:" + maximo);
//         minimo = Math.Min(numero3,numero4);
//         Console.WriteLine("El menor de los numeros es: " + minimo);
//     }else
//     {
//         Console.WriteLine("Numero ingresado incorrecto");
//     }
// }else
// {
//     Console.WriteLine("Numero ingresado incorrecto");
// }

//EJERCICIO 4
// string texto1,texto2;

// Console.WriteLine("Ingrese un texto");
// texto1 = Console.ReadLine();
// Obtener la longitud de la cadena y muestre por pantalla.
// Console.WriteLine($"La longitud de la cadena ingresada es: {texto1.Length}");
// Console.WriteLine($"El texto ingresado es : {texto1}");

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
// Console.WriteLine("Ingrese un nuevo texto");
// texto2 = Console.ReadLine();
// Console.WriteLine($"Los 2 textos concatenados quedaria: {texto1}{texto2}");

//Extraer una subcadena de la cadena ingresada.
// Console.WriteLine($"La subcadena extraida desde la posicion 5 y de longitud 2 es: {texto1.Substring(5,2)}");

//Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado. Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente.

//Realizado en el Ejercicio 2

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
// foreach (char c in texto1)
// {
//     Console.WriteLine(c);
// }

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
// bool resultadoBusqueda = texto1.Contains("jorge");
// Console.WriteLine($"La cadena contiene la palabara \"jorge\"? {resultadoBusqueda}");

//Convierta la cadena a mayúsculas y luego a minúsculas.
// Console.WriteLine($"La cadena en minisculas es: {texto1.ToLower()}");
// Console.WriteLine($"La cadena en mayusculas es: {texto1.ToUpper()}");

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
// string[] cadenaSeparada = texto1.Split(" ");
// foreach (var cadenasSeparadas in cadenaSeparada)
// {
//     Console.WriteLine(cadenasSeparadas);
// }

//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
// int operando;
// Console.WriteLine("Ingrese la operacion que desea realizar:");
// string operacionIngresada = Console.ReadLine();
// bool operadorSuma = operacionIngresada.Contains("+");
// bool operadorResta = operacionIngresada.Contains("-");
// bool operadorProducto = operacionIngresada.Contains("*");
// bool operadorDivision = operacionIngresada.Contains("/");

// int resultado=0;

// if (operadorSuma)
// {
//     string[] operandos = operacionIngresada.Split("+");
//     for (int i = 0; i < operandos.Length; i++)
//     {
//         operando = int.Parse(operandos[i]);
//         resultado += operando;
//     }
// }

// if (operadorResta) // Valido solo para 2 numeros ingresados
// {
//     string[] operandos = operacionIngresada.Split("-");
//     resultado = int.Parse(operandos[0]) - int.Parse(operandos[1]);

// }

// if (operadorProducto) // Valido solo para 2 numeros ingresados
// {
//     string[] operandos = operacionIngresada.Split("*");
//     resultado = int.Parse(operandos[0]) * int.Parse(operandos[1]);
// }

// if (operadorDivision) // Valido solo para 2 numeros ingresados
// {
//     string[] operandos = operacionIngresada.Split("/");
//     resultado = int.Parse(operandos[0]) / int.Parse(operandos[1]);
// }

// Console.WriteLine($"El resultado es: {resultado}");

//EJERCICIO 5
//Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido.
using System.Text.RegularExpressions;
int menu;
// Console.WriteLine("VERIFICACION DE CORREO ELECTRONICO");
// do
// {
// Console.WriteLine("Ingrese un correo electronico:");
// string email = Console.ReadLine();
// Console.WriteLine(Regex.IsMatch(email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$"));
// Console.WriteLine("Desea verificar otro correo electronico? 1-SI, 2-NO");
// menu = int.Parse(Console.ReadLine());
// } while (menu == 1);

Console.WriteLine("VERIFICACION DE DIRECCION WEB"); // solo .com
do
{
Console.WriteLine("Ingrese una direccion web:");
string web = Console.ReadLine();
Console.WriteLine(Regex.IsMatch(web,@"^www.{3}[^\.\s]+\.[^\.\s]+$"));
Console.WriteLine("Desea verificar otra direccion web? 1-SI, 2-NO");
menu = int.Parse(Console.ReadLine());
} while (menu == 1);