using static System.Runtime.InteropServices.JavaScript.JSType;

void adivinar()
{
    const int oportunidades = 4;
    int NumeroCPU, NumeroUsuario;
    byte Intentos, BanderaControl;
    string Linea;
    Random rand = new Random();

    NumeroCPU = rand.Next(1, 21); // Genera un número aleatorio entre 1 y 20

    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Estoy pensando en un número, ¿cuál será?");
        Linea = Console.ReadLine();
        NumeroUsuario = Convert.ToInt32(Linea);
        if (NumeroCPU == NumeroUsuario)
        {
            Console.WriteLine("¡Adivinaste!");
            BanderaControl = 1;
        }
        else
        {
            if (NumeroUsuario > NumeroCPU)
            {
                Console.WriteLine("El número es menor.");
            }
            else
            {
                Console.WriteLine("El número es mayor.");
            }
            Intentos++;
        }
    } while (Intentos <= oportunidades && BanderaControl == 0);

    if (BanderaControl == 0)
    {
        Console.WriteLine("El número fue: " + NumeroCPU);
    }

}


  void mayor_menor ()

{
    int mayor = 0;
    int numero = 0;
    int menor = 10;
    Random random = new Random();
    for (int i = 0;i<5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine("El mayor es = " + mayor);
    Console.WriteLine("El mayor es = " + menor);
}


void catcher()
{
    int cantidad = 0;
    Console.WriteLine("ingrese una cantidad");
    try
    {

        cantidad = int.Parse(Console.ReadLine());
         }
        //cantidad = cantidad / 0;
            
            catch (FormatException fex)
    {
        Console.WriteLine("ingresó mal el númeri" + fex.Message);
    }catch (Exception ex) 
    {
        Console.WriteLine("hay un error de otro tipo "+ ex.Message);
    }
    if (cantidad > 0) 
    {
        Console.WriteLine("cantidad ingresada=" + cantidad);   
    }
        }



//void ejemplolArreglo()
//{
//    string[] nombres = new string[elementos];//define y creanis ek arreglo 

//    //int suma = 0;
//    //numero[0] = 45;
//    //numero[1] = 50;
//    //numero[2] = 68;
//    //numero[3] = 70;
//    //numero[4] = 86;
//    //numero[5] = 92;
//    //numero[6] = 69;

//    nombres[0] = "maria";
//    nombres[1] = "juan";
//    nombres[2] = "pedro";
//    nombres[3] = "byron";
//    nombres[4] = "brandon";
//    nombres[5] = "braulio";
//    nombres[6] = "martin";
//    nombres[7] = "pablo";
//    nombres[8] = "manuel";
//    nombres[9] = "isaac";
//    int elementos = nombres.Length;

//    int primerp = 0;
//    int segundop = 0;
//    int tercerp = 0;


//    for (int i = 0; i <elementos;  i++)
//    {
//        //suma=suma+nombres[i];    
//        //Console.WriteLine(nombres[1]);
//        Console.WriteLine(nombres[i]);


//    }
//    //Console.WriteLine("sumatoria="+suma );
//    //Console.WriteLine("el promedio es " + suma / elementos);
//}


void rifa()
{
    string[] nombres = new string[10];

    nombres[0] = "maria";
    nombres[1] = "juan";
    nombres[2] = "pedro";
    nombres[3] = "byron";
    nombres[4] = "brandon";
    nombres[5] = "braulio";
    nombres[6] = "martin";
    nombres[7] = "pablo";
    nombres[8] = "manuel";
    nombres[9] = "isaac";

    int elementos = nombres.Length;

    // Generar dos números aleatorios únicos
    Random rand = new Random();
    int primerGanador = rand.Next(elementos);
    int segundoGanador;
    do
    {
        segundoGanador = rand.Next(elementos);
    } while (segundoGanador == primerGanador);

    // Imprimir los nombres de los ganadores
    Console.WriteLine("Primer ganador: " + nombres[primerGanador]);
    Console.WriteLine("Segundo ganador: " + nombres[segundoGanador]);
}


rifa();







//ejemplolArreglo();
//////adivinar ();
//////mayor_menor();
////catcher ();





