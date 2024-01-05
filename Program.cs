// Un programa que seleccione aleatoriamente a 2 estudiantes de ese listado, un primer estudiante que realizara la presentacion en vivo, y un segundo estudiante que traera un ejercicio realizado. requisito a lograr, el programa se mantenga en ejecucion y la seleccion no se repita cuando se ejecute nuevamente.

int opcion = 1;
  
List<string> num = new List<String>();
num.Add("Alan");
num.Add( "Andyson");
num.Add( "Aneuris");
num.Add("Ángel");
num.Add("Angel Gabriel");
num.Add("Anthony");
num.Add("Daniel");
num.Add("Daninson");
num.Add("Emil");
num.Add("Franchesca");
num.Add("Gabriel");
num.Add("Gabriel Adolfo");
num.Add("Giuseppe");
num.Add("Holy");
num.Add("Ivan");
num.Add("Jayson");
num.Add("Jorgelis");
num.Add("José");
num.Add("Jose");
num.Add("Juan");
num.Add("Julio");
num.Add("Junior");
num.Add("Lenny");
num.Add("Luis");
num.Add("Naomy");
num.Add("Odiseo");
num.Add("Ragbert");
num.Add("Sail");
num.Add("Tony");

string s;

  static void escribir(int vel, string texto)
{
    for(int i =0; i<texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }
}

while(opcion == 1)
{
    int j;
    Console.Clear();
    j = num.Count;

    int a = 0 , b = 0 , c = 0;
    var rand = new Random();


    while(a == 0)
    {
        b = rand.Next(0,j);
        c = rand.Next(0,j);
        if(b != c)
        {
            a = 1;
            num.RemoveAt(b);
            num.RemoveAt(c);
        }
        
    }

    bool enc = false;

    while(enc == false)
    {
        escribir(50,"Estudiante a presentar en vivo: ");
        Console.WriteLine();
        escribir(75,num[b]);
        Console.WriteLine();
        escribir(50,"El estudiante se encuentra presente?, escribe s o n");
        Console.WriteLine();
        s = Console.ReadLine()??"";
        Console.WriteLine();
        if(s=="s")
        {
            enc = true;
        }
        else
        {
            a = 0;
            while(a == 0)
            {
                b = rand.Next(0,j);
                a = 1;
                num.RemoveAt(b);
                
            }
        }

    }

    enc = false;

    while(enc == false)
    {
        escribir(50,"Estudiante a realizar ejercicio: ");
        Console.WriteLine();
        escribir(75,num[c]);
        Console.WriteLine();
        escribir(50,"El estudiante se encuentra presente?, escribe s o n");
        Console.WriteLine();
        s = Console.ReadLine()??"";
        Console.WriteLine();
        if(s=="s")
        {
            enc = true;
        }
        else
        {
            a = 0;
            while(a == 0)
            {
                c = rand.Next(0,j);
                a = 1;
                num.RemoveAt(c);
                
            }
        }

    }

    escribir(50,"presione 1 para continuar, 0 para salir ");
    Console.WriteLine();
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Muchas gracias por usar este programa :)");

}

Console.ReadKey();