using System;

namespace CA3
{
    class Program1
    {
        static int option = 0;

        static void BinaryConversion()
        {
            int o = 0;
            string binary = "";
            Console.Clear();
            Console.WriteLine("Sistemas numéricos");
            Console.WriteLine("Conversiones Binarias");
            Console.WriteLine("Seleccione la opción a convertir");
            Console.WriteLine("1. Octal");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("3. Hexadecimal");
            o = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número binario");
            binary = Console.ReadLine();

            if (o == 1)
            {
                int integer = Convert.ToInt32(binary, 2);
                Console.WriteLine(Convert.ToString(integer, 8));
            }
            else if (o == 2)
            {
                int integer = Convert.ToInt32(binary, 2);
                Console.WriteLine(Convert.ToString(integer, 10));
            }
            else if (o == 3)
            {
                int integer = Convert.ToInt32(binary, 2);
                Console.WriteLine(Convert.ToString(integer, 16));
            }
            Console.ReadLine();
        }

        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Sistemas numéricos");
            Console.WriteLine("1. Binario");
            Console.WriteLine("2. Octal");
            Console.WriteLine("3. Decimal");
            Console.WriteLine("4. Hexadecimal");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción.");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        BinaryConversion();
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
    }
}
