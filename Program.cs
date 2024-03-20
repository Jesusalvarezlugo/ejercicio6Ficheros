namespace ejercicio6Ficheros
{
    class Program
    {

        static int  numLinea;
        static int posicion;
        static string textoACambiar;
        static string rutaArchivo;
        static int opcionArch;
        static int opcionUsu;
        public static void Main(string[] args)
        {
            /*
                 Haz un programa que funcione como un editor de texto básico. El usuario debe poder abrir un archivo de texto,
                 ver su contenido, seleccionar una línea y modificarla, así como insertar 
                 texto en una posición específica de cualquier  línea. 
                 Además, el programa debe permitir al usuario guardar los cambios realizados en el archivo.             
             */

            

            Console.WriteLine("1. archivo ");
            Console.WriteLine("2. archivo 1");
            Console.WriteLine("3. archivo 2");
            Console.WriteLine("#################");
            Console.WriteLine("elija una opcion: ");
            opcionArch = Console.ReadKey(true).KeyChar - ('0');

            switch (opcionArch)
            {
                case 1:
                    Console.WriteLine("Ha elegido el archivo");
                    menuArchivo();

                    break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }

        }

        public static  void menuArchivo()
        {
            

            Console.WriteLine("1. Ver contenido del archivo");
            Console.WriteLine("2. Modificar una linea del archivo");
            Console.WriteLine("3. Insertar texto en una posición específica de cualquier  línea");
            Console.WriteLine("###################################################################");
            Console.WriteLine("Elija una opcion: ");
            opcionUsu=Console.ReadKey(true).KeyChar- ('0');

            switch (opcionUsu)
            {
                case 1:
                    Console.WriteLine("Ver contenido del archivo");

                    break;

                case 2:
                    Console.WriteLine("Modificar una linea del archivo");
                    break;

                case 3:
                    Console.WriteLine("Insertar texto en una posición específica de cualquier  línea");
                    break;

                default:
                    break;
            }
        }
    }
}
