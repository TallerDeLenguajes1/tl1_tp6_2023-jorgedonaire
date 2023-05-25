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

int numero1, numero2, resultado, menu, opcionRepetir;
string opcionIngresada;



do
{
    Console.WriteLine("----- CALCULADORA -----");
    Console.WriteLine("Ingrese la operacion que desea realizar: ");
    Console.WriteLine("\t1 - Sumar");
    Console.WriteLine("\t2 - Restar");
    Console.WriteLine("\t3 - Multiplicar");
    Console.WriteLine("\t4 - Dividir");

    opcionIngresada = Console.ReadLine();
    bool control = int.TryParse(opcionIngresada,out menu);

    if (control)
    {
        switch (menu)
        {
            case 1:
                Console.WriteLine("Ingrese el primer numero a sumar: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero a sumar: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1+numero2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            case 2:
                Console.WriteLine("Ingrese el primer numero al que se le va restar: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero que va restar al anterior: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1-numero2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            case 3:
                Console.WriteLine("Ingrese el primer numero a multiplicar: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero a multiplicar: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1*numero2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            case 4:
                Console.WriteLine("Ingrese el primer numero a dividir: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero que va dividir el anterior: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1/numero2;
                Console.WriteLine("El resultado es: "+ resultado);
                break;
            default:
                Console.WriteLine("Opcion ingresada incorrecta");
                break;
        }
        
    }else
    {
        Console.WriteLine("Opcion ingresada incorrecta");
    }

    Console.WriteLine("Desea realizar otra operacion? 1 - SI , 2 - NO : ");
    opcionRepetir = Convert.ToInt32(Console.ReadLine());
} while (opcionRepetir == 1);
