namespace Ejercicio2Repaso
{
    internal class Program
    {
        static List<Cliente> Clientes = new List<Cliente>();
        static List<Paquete> Paquetes = new List<Paquete>();

        static void Main(string[] args)
        {
            InicializarDatos();

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Mostrar Paquetes");
                Console.WriteLine("2. Mostrar Clientes");
                Console.WriteLine("3. Total Recaudado");
                Console.WriteLine("4. Paquete más vendido");
                Console.WriteLine("5. Series con ranking > 3.5");
                Console.WriteLine("6. Ingresar Cliente Nuevo");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        MostrarPaquetes(); 
                        break;
                    case 2: 
                        MostrarClientes();
                        break;
                    case 3: 
                        TotalRecaudado();
                        break;
                    case 4: 
                        PaqueteMasVendido(); 
                        break;
                    case 5: 
                        SeriesRankingAlto(); 
                        break;
                    case 6: 
                        IngresarCliente();
                        break;
                }
            } while (opcion != 0);
        }

        static void InicializarDatos()
        {
            var basico = new PaqueteBasico(1000);
            basico.AgregarSerie(new Serie("Serie A", 2, 20, 40, 4.2, "Drama", "Director A"));

            var silver = new PaqueteSilver(1200);
            silver.AgregarSerie(new Serie("Serie B", 3, 30, 45, 3.8, "Acción", "Director B"));

            var premium = new PaquetePremium(1500);
            premium.AgregarSerie(new Serie("Serie C", 5, 50, 50, 4.5, "Sci-Fi", "Director C"));

            Paquetes.Add(basico);
            Paquetes.Add(silver);
            Paquetes.Add(premium);

            var c1 = new Cliente(1, "Juan", "Pérez", "12345678", new DateTime(1990, 1, 1));
            c1.PaqueteContratado = premium;

            var c2 = new Cliente(2, "Ana", "Gómez");
            c2.PaqueteContratado = silver;

            Clientes.Add(c1);
            Clientes.Add(c2);
        }

        static void MostrarPaquetes()
        {
            foreach (var p in Paquetes)
            {
                Console.WriteLine($"\n{p.Nombre} - Precio: {p.CalcularPrecio()}");
                foreach (var s in p.Series)
                {
                    Console.WriteLine($"   - {s}");
                }
            }
        }

        static void MostrarClientes()
        {
            foreach (var c in Clientes)
            {
                Console.WriteLine($"{c} - Paquete: {c.PaqueteContratado?.Nombre ?? "Ninguno"}");
            }
        }

        static void TotalRecaudado()
        {
            double total = 0;
            foreach (var c in Clientes)
            {
                if (c.PaqueteContratado != null)
                    total += c.PaqueteContratado.CalcularPrecio();
            }
            Console.WriteLine($"\nTotal recaudado: {total}");
        }

        static void PaqueteMasVendido()
        {
            var conteo = new Dictionary<string, int>();
            foreach (var c in Clientes)
            {
                if (c.PaqueteContratado != null)
                {
                    string nombre = c.PaqueteContratado.Nombre;
                    if (!conteo.ContainsKey(nombre))
                        conteo[nombre] = 0;
                    conteo[nombre]++;
                }
            }

            int max = 0;
            string masVendido = "";
            foreach (var kv in conteo)
            {
                if (kv.Value > max)
                {
                    max = kv.Value;
                    masVendido = kv.Key;
                }
            }

            Console.WriteLine($"\nPaquete más vendido: {masVendido} ({max} ventas)");
        }

        static void SeriesRankingAlto()
        {
            Console.WriteLine("\nSeries con ranking > 3.5:");
            foreach (var p in Paquetes)
            {
                foreach (var s in p.Series)
                {
                    if (s.Ranking > 3.5)
                        Console.WriteLine($" - {s.Nombre} ({s.Ranking})");
                }
            }
        }

        static void IngresarCliente()
        {
            Console.WriteLine("\n--- Nuevo Cliente ---");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Fecha Nacimiento (yyyy-mm-dd): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            var cliente = new Cliente(codigo, nombre, apellido, dni, fecha);

            Console.WriteLine("\nSeleccione Paquete:");
            Console.WriteLine("1. Básico");
            Console.WriteLine("2. Silver");
            Console.WriteLine("3. Premium");
            Console.Write("Opción: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: 
                    cliente.PaqueteContratado = Paquetes.Find(p => p is PaqueteBasico); 
                    break;
                case 2: 
                    cliente.PaqueteContratado = Paquetes.Find(p => p is PaqueteSilver); 
                    break;
                case 3: 
                    cliente.PaqueteContratado = Paquetes.Find(p => p is PaquetePremium);
                    break;
                default: 
                    Console.WriteLine("Opción inválida, no se asignó paquete."); 
                    break;
            }

            Clientes.Add(cliente);
            Console.WriteLine("\nCliente agregado con éxito.");
        }
    }
}
