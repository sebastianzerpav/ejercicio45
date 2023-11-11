//Dado un vector de tamaño N, llenar el vector aleatoriamente con números enteros. 
//    Pedir por pantalla un número y determinar si ese número se encuentra en el vector,
//    en caso afirmativo, indicar su posición (índice) dentro del vector, en caso negativo,
//    mostrar el mensaje “El número no existe”.

public class ejercicio45
{
    static void Main(string[] args)
    {

        bool repetir = true;
        do {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Vamos a jugar!");
            Console.Write("¡ADIVINA EL NÚMERO!\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n¡EMPECEMOS!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vamos a generar, aleatoriamente, una cantidad de números enteros que nos indiques.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¿Cuántos números deseas generar aleatoriamente? ");
            int n = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡IMPORTANTE!");
            Console.WriteLine("---> Los números generados son números enteros entre 1 y 10.");
            Console.WriteLine($"---> Hemos generado {n} números enteros.\n");

            int[] aleatorios = new int[n];

            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                aleatorios[i] = random.Next(1, 11);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡AHORA SÍ!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Introduce un número entero del 1 al 10 para ver si está en los números generados aleatoriamente: ");
            int numAdivinar = int.Parse(Console.ReadLine());
            Console.Write($"\n");

            bool salir = false, encontrado = false;
            while (salir == false)
            {
                for (int i = 0; i < n; i++)
                {
                    if (numAdivinar == aleatorios[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"¡El número que elegiste ({numAdivinar}) es el número {i + 1} de los generados aleatoriamente.");
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El número {numAdivinar} no está entre los números generados aleatoriamente.");
                }

                if (encontrado || !encontrado) { salir = true; }
            }

            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"El número {i + 1} generado aleatoriamente es: {aleatorios[i]}");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n¿Deseas volver a jugar?");
            Console.WriteLine("S para seguir, N para terminar");

            char respuestaRepetir = Console.ReadLine().ToUpper()[0]; 

            if (respuestaRepetir != 'S')
            { repetir = false; }

        } while (repetir);
    }
}
