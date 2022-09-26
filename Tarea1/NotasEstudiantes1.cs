using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea1
{
    internal class NotasEstudiantes1
    {
        static string[] Estudiantes = new string[5];
        static float[] Notas = new float[5];
        static int indice = 0;

        public void menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1. Ingresar nombres y notas");
                Console.WriteLine("2. Promedio notas");
                Console.WriteLine("3. Notas mas alta");
                Console.WriteLine("4. Nota mayor y menor al promedio");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        NotasEstudiantes();
                        break;
                    case 2:
                        Console.WriteLine("Promedio de notas: {0}", CalculoPromedio());
                        break;
                    case 3:
                        NotaMayor();
                        break;
                    case 4:

                        break;
                    case 5:
                        break;

                }


            }
            while (opcion != 5);
        }
        public static void NotasEstudiantes()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Nombre del estudiantes");
                Estudiantes[indice] = Console.ReadLine();
                Console.WriteLine("Nota del estudiantes");
                Notas[indice] = Convert.ToInt32(Console.ReadLine());
                indice++;
                Console.WriteLine("Ingresar otro estudiantes 1- Si o 2- No");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while (opcion != 2);
        }
        public float CalculoPromedio()
        {
            float total = 0;
            for (int i = 0; i < indice; i++)
            {
                total += Notas[i];

            }
            total /= indice;
            return total;


        }
        public void NotaMayor()
        {
            Array.Sort(Notas);
            Array.Reverse(Notas);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Notas[i] + " ");
            }


            {

                int ma = 0, me = 0, num = 0;
                Console.WriteLine("Cuantos notas va ingresar");
                int numeros = int.Parse(Console.ReadLine());
                for (int i = 0; i < numeros; i++)
                {
                    Console.WriteLine("Digite una nota: ");
                    num = int.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        ma = num;
                        me = num;
                    }
                    if (num > ma) { ma = num; }
                    if (num < me) { me = num; }



                    num = 0;
                }

                Console.WriteLine("La nota mayor es: " + ma);
                Console.WriteLine("La nota menor es: " + me);

            }
        }

    }
}   

        


    

