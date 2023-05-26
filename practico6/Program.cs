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

// EJERCICIO 3
int numero;
float numeroFloat=1.2f;
bool control;

Console.WriteLine("Ingrese un numero:");
control = int.TryParse(Console.ReadLine(),out numero);

if (control)
{
    Console.WriteLine("El valor absoluto del numero es: "+ Math.Abs(numero));
    Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero,2));
    Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(numero));
    Console.WriteLine("El seno del numero es: " + Math.Sin(numero));
    Console.WriteLine("El coseno del numero es: " + Math.Cos(numero));
    Console.WriteLine("La parte entero del numero es: " + Math.Truncate(numeroFloat));
}else
{
    Console.WriteLine("Numero ingresado incorrecto");
}

int numero1, numero2, maximo, minimo;
bool control1, control2;

Console.WriteLine("Ingrese 2 numeros ");
Console.WriteLine("1er numero:");
control1 = int.TryParse(Console.ReadLine(),out numero1);
if (control1)
{
    Console.WriteLine("2do numero:");
    control2 = int.TryParse(Console.ReadLine(),out numero2);
    if (control2)
    {
        maximo = Math.Max(numero1,numero2);
        Console.WriteLine("El mayor de los numeros es:" + maximo);
        minimo = Math.Min(numero1,numero2);
        Console.WriteLine("El menor de los numeros es: " + minimo);
    }else
    {
        Console.WriteLine("Numero ingresado incorrecto");
    }
}else
{
    Console.WriteLine("Numero ingresado incorrecto");
}


