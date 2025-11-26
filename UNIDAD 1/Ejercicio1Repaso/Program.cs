namespace Ejercicio1Repaso
{
    internal class Program
    {
        private static Banco banco;

        static void Main(string[] args)
        {
            banco = new Banco();
            Console.WriteLine("=== SISTEMA BANCARIO ===");
            Console.WriteLine($"Bienvenido a {banco.Nombre}");
            Console.WriteLine();

            bool continuar = true;

            while (continuar)
            {
                try
                {
                    MostrarMenu();
                    int opcion = LeerOpcion();
                    continuar = ProcesarOpcion(opcion);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Crear Cliente");
            Console.WriteLine("2. Modificar Cliente");
            Console.WriteLine("3. Eliminar Cliente");
            Console.WriteLine("4. Crear Cuenta de Ahorros");
            Console.WriteLine("5. Crear Cuenta Corriente");
            Console.WriteLine("6. Depositar o Retirar");
            Console.WriteLine("7. Consultar Saldo / Listar Cuentas");
            Console.WriteLine("8. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");
        }

        static int LeerOpcion()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Debe ingresar un número válido.");
            }
        }

        static bool ProcesarOpcion(int opcion)
        {
            try
            {
                switch (opcion)
                {
                    case 1:
                        CrearCliente();
                        break;
                    case 2:
                        ModificarCliente();
                        break;
                    case 3:
                        EliminarCliente();
                        break;
                    case 4:
                        CrearCuentaAhorros();
                        break;
                    case 5:
                        CrearCuentaCorriente();
                        break;
                    case 6:
                        OperarCuenta();
                        break;
                    case 7:
                        ListarCuentasYSaldo();
                        break;
                    case 8:
                        Console.WriteLine("¡Gracias por usar el sistema bancario!");
                        return false;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            return true;
        }

        static void CrearCliente()
        {
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Nombre y Apellido: ");
            string nombre = Console.ReadLine();
            Console.Write("Teléfono: ");
            int tel = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            var cliente = new Cliente(dni, nombre, tel, email, fecha);
            var resultado = banco.repositorioCliente.Agregar(cliente);
            Console.WriteLine(resultado);
        }

        static void ModificarCliente()
        {
            Console.Write("Ingrese DNI del cliente a modificar: ");
            int dni = int.Parse(Console.ReadLine());

            var cliente = banco.repositorioCliente.Listar().FirstOrDefault(c => c.Dni == dni);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                return;
            }

            Console.Write("Nuevo Nombre y Apellido: ");
            cliente.NombreyApellido = Console.ReadLine();
            Console.Write("Nuevo Teléfono: ");
            cliente.Tel = int.Parse(Console.ReadLine());
            Console.Write("Nuevo Email: ");
            cliente.Email = Console.ReadLine();
            Console.Write("Nueva Fecha de Nacimiento (yyyy-MM-dd): ");
            cliente.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(banco.repositorioCliente.Modificar(cliente));
        }

        static void EliminarCliente()
        {
            Console.Write("Ingrese DNI del cliente a eliminar: ");
            int dni = int.Parse(Console.ReadLine());

            var cliente = banco.repositorioCliente.Listar().FirstOrDefault(c => c.Dni == dni);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                return;
            }

            Console.WriteLine(banco.repositorioCliente.Borrar(cliente));
        }

        static void CrearCuentaAhorros()
        {
            Console.Write("Ingrese DNI del cliente: ");
            int dni = int.Parse(Console.ReadLine());
            var cliente = banco.repositorioCliente.Listar().FirstOrDefault(c => c.Dni == dni);
            if (cliente == null) { Console.WriteLine("Cliente no encontrado."); return; }

            Console.Write("Ingrese código para la cuenta: ");
            int codigo = int.Parse(Console.ReadLine());

            banco.CrearCajaAhorros(codigo, cliente);
            Console.WriteLine("Cuenta de Ahorros creada con éxito.");
        }

        static void CrearCuentaCorriente()
        {
            Console.Write("Ingrese DNI del cliente: ");
            int dni = int.Parse(Console.ReadLine());
            var cliente = banco.repositorioCliente.Listar().FirstOrDefault(c => c.Dni == dni);
            if (cliente == null) { Console.WriteLine("Cliente no encontrado."); return; }

            Console.Write("Ingrese código para la cuenta: ");
            int codigo = int.Parse(Console.ReadLine());

            banco.CrearCuentaCorriente(codigo, cliente);
            Console.WriteLine("Cuenta Corriente creada con éxito.");
        }

        static void OperarCuenta()
        {
            Console.Write("Ingrese código de cuenta: ");
            int codigo = int.Parse(Console.ReadLine());
            var cuenta = banco.ObtenerCuenta(codigo);
            if (cuenta == null) { Console.WriteLine("Cuenta no encontrada."); return; }

            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.Write("Seleccione operación: ");
            int op = int.Parse(Console.ReadLine());

            Console.Write("Ingrese monto: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            try
            {
                if (op == 1) banco.RealizarDeposito(codigo, monto);
                else if (op == 2) banco.RealizarRetiro(codigo, monto);
                Console.WriteLine("Operación realizada con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListarCuentasYSaldo()
        {
            foreach (var cliente in banco.repositorioCliente.Listar())
            {
                Console.WriteLine($"Cliente: {cliente.NombreyApellido} - DNI: {cliente.Dni}");
                foreach (var cuenta in cliente.Cuentas)
                {
                    Console.WriteLine($"  {cuenta.ObtenerTipoCuenta()} - Código: {cuenta.Codigo} - Saldo: {cuenta.ConsultarSaldo():C}");
                }
            }
        }
    }
}
