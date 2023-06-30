using System;
using System.Collections.Generic;

namespace RegistroEmpleados
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Profesion { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public double Salario { get; set; }
        public double HorasExtra { get; set; }
        public double AFP { get; set; }
        public double SeguroMedico { get; set; }
        public double ISR { get; set; }
        public double Prestamo { get; set; }

        public Empleado(string nombre, string apellidos, string cedula, string direccion, string telefono, string profesion, string departamento, string puesto)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Cedula = cedula;
            Direccion = direccion;
            Telefono = telefono;
            Profesion = profesion;
            Departamento = departamento;
            Puesto = puesto;
            Salario = 0;
            HorasExtra = 0;
            AFP = 0;
            SeguroMedico = 0;
            ISR = 0;
            Prestamo = 0;
        }
    }

    class Program
    {
        static List<Empleado> empleados = new List<Empleado>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("1. Registrar empleado");
                Console.WriteLine("2. Buscar empleado");
                Console.WriteLine("3. Borrar empleado");
                Console.WriteLine("4. Actualizar empleado");
                Console.WriteLine("5. Calcular nómina");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese la opción deseada: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarEmpleado();
                        break;
                    case "2":
                        BuscarEmpleado();
                        break;
                    case "3":
                        BorrarEmpleado();
                        break;
                    case "4":
                        ActualizarEmpleado();
                        break;
                    case "5":
                        CalcularNomina();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
            }
        }

        static void RegistrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("=== Registrar Empleado ===");
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese los apellidos del empleado: ");
            string apellidos = Console.ReadLine();
            Console.Write("Ingrese la cédula del empleado: ");
            string cedula = Console.ReadLine();

            // Validar si el empleado ya existe por su cédula
            if (empleados.Exists(e => e.Cedula == cedula))
            {
                Console.WriteLine("Ya existe un empleado con la misma cédula.");
                return;
            }

            // Resto del código para ingresar los demás detalles del empleado y agregarlo a la lista
            Console.Write("Ingrese la dirección del empleado: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el teléfono del empleado: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese la profesión del empleado: ");
            string profesion = Console.ReadLine();
            Console.Write("Ingrese el departamento del empleado: ");
            string departamento = Console.ReadLine();
            Console.Write("Ingrese el puesto del empleado: ");
            string puesto = Console.ReadLine();

            Empleado empleado = new Empleado(nombre, apellidos, cedula, direccion, telefono, profesion, departamento, puesto);
            empleados.Add(empleado);

            Console.WriteLine("Empleado registrado exitosamente.");
        }

        static void BuscarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("=== Buscar Empleado ===");
            Console.Write("Ingrese la cédula del empleado: ");
            string cedula = Console.ReadLine();

            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine("Nombre: " + empleado.Nombre);
                Console.WriteLine("Apellidos: " + empleado.Apellidos);
                Console.WriteLine("Dirección: " + empleado.Direccion);
                Console.WriteLine("Teléfono: " + empleado.Telefono);
                Console.WriteLine("Profesión: " + empleado.Profesion);
                Console.WriteLine("Departamento: " + empleado.Departamento);
                Console.WriteLine("Puesto: " + empleado.Puesto);
                Console.WriteLine("Salario: " + empleado.Salario);
                Console.WriteLine("Horas Extras: " + empleado.HorasExtra);
                Console.WriteLine("AFP: " + empleado.AFP);
                Console.WriteLine("Seguro Médico: " + empleado.SeguroMedico);
                Console.WriteLine("ISR: " + empleado.ISR);
                Console.WriteLine("Préstamo: " + empleado.Prestamo);
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        static void BorrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("=== Borrar Empleado ===");
            Console.Write("Ingrese la cédula del empleado a borrar: ");
            string cedula = Console.ReadLine();

            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado borrado exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        static void ActualizarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("=== Actualizar Empleado ===");
            Console.Write("Ingrese la cédula del empleado a actualizar: ");
            string cedula = Console.ReadLine();

            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine("Nombre: " + empleado.Nombre);
                Console.WriteLine("Apellidos: " + empleado.Apellidos);
                Console.WriteLine("Dirección: " + empleado.Direccion);
                Console.WriteLine("Teléfono: " + empleado.Telefono);
                Console.WriteLine("Profesión: " + empleado.Profesion);
                Console.WriteLine("Departamento: " + empleado.Departamento);
                Console.WriteLine("Puesto: " + empleado.Puesto);

                Console.WriteLine();
                Console.WriteLine("Ingrese los nuevos datos:");

                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Apellidos: ");
                empleado.Apellidos = Console.ReadLine();
                Console.Write("Dirección: ");
                empleado.Direccion = Console.ReadLine();
                Console.Write("Teléfono: ");
                empleado.Telefono = Console.ReadLine();
                Console.Write("Profesión: ");
                empleado.Profesion = Console.ReadLine();
                Console.Write("Departamento: ");
                empleado.Departamento = Console.ReadLine();
                Console.Write("Puesto: ");
                empleado.Puesto = Console.ReadLine();

                Console.WriteLine("Empleado actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        static void CalcularNomina()
        {
            Console.Clear();
            Console.WriteLine("=== Calcular Nómina ===");
            Console.Write("Ingrese la cédula del empleado: ");
            string cedula = Console.ReadLine();

            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine("Nombre: " + empleado.Nombre);
                Console.WriteLine("Apellidos: " + empleado.Apellidos);
                Console.WriteLine("Departamento: " + empleado.Departamento);
                Console.WriteLine("Puesto: " + empleado.Puesto);

                Console.WriteLine();
                Console.Write("Ingrese el salario base del empleado: ");
                double salarioBase = Convert.ToDouble(Console.ReadLine());

                empleado.Salario = salarioBase;

                Console.Write("Ingrese las horas extras trabajadas: ");
                double horasExtra = Convert.ToDouble(Console.ReadLine());

                empleado.HorasExtra = horasExtra;

                // Calcular los descuentos
                double afp = salarioBase * 0.0287;  // Porcentaje de AFP en República Dominicana
                empleado.AFP = afp;

                double seguroMedico = salarioBase * 0.0304;  // Porcentaje de Seguro Médico en República Dominicana
                empleado.SeguroMedico = seguroMedico;

                // Calcular el ISR (Impuesto sobre la Renta) según las tablas y rangos establecidos
                double isr = CalcularISR(empleado.Salario, empleado.HorasExtra);
                empleado.ISR = isr;

                // Aquí podrías incluir el cálculo de otros descuentos, como préstamos a los empleados

                // Calcular el salario neto
                double salarioNeto = salarioBase + horasExtra - afp - seguroMedico - isr;
                Console.WriteLine("Salario Neto: " + salarioNeto);

                Console.WriteLine("Nómina calculada exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        static double CalcularISR(double salarioBase, double horasExtra)
        {
            // Aquí deberías implementar la lógica para calcular el ISR (Impuesto sobre la Renta)
            // según las tablas y rangos establecidos por la Dirección General de Impuestos Internos de República Dominicana.
            // Dado que no tengo acceso a las tablas de ISR actualizadas, no puedo proporcionar un ejemplo preciso en este momento.
            // Te recomendaría consultar las tablas y rangos vigentes en la página oficial de la DGII o buscar información adicional en línea.

            // Aquí hay un ejemplo básico para calcular el ISR utilizando una tasa fija del 10%:
            double tasaISR = 0.10;  // Tasa fija del 10%
            double salarioTotal = salarioBase + horasExtra;
            double isr = salarioTotal * tasaISR;

            return isr;
        }
    }
}
