// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;
// int b;

// a=10;
// b=a;

// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);

// EJERCICIO 1
int num=0;
Console.WriteLine("Ingrese el numero que quiere invertir");
string numero;

numero = Console.ReadLine();

bool control  = int.TryParse(numero,out num);
//156
int inversion=0;

if (control)
{
    while (num != 0)
    {
        inversion = inversion*10 + num % 10;
        num = num/10;
    }
    Console.WriteLine(inversion);
} else
{
    Console.WriteLine("No ingreso un numero");
}

// EJERCICIO 3

