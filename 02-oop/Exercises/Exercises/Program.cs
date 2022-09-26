using System.Threading.Channels;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool exit = false;

            Empleado emp = new Empleado("Jose Ramón", "López", 49, "53817232S", 25000, "617756500");
            Directivo d = new Directivo("Mauricio", "Colmenero", 53, "12345678A", "Hostelería", 50);
            EmpleadoEspecial empE = new EmpleadoEspecial("Miguel", "Miguelez", 19, "53817232S");

            static void mostrarPasta(IPastaGansa iPG)
            {
                Console.Write("\t\tHow much does the company earn?: ");
                try
                {
                    double ben = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\tWin money: " + iPG.ganarPasta(ben));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error 404");
                }
            }

            while (!exit)
            {
                try
                {
                    Console.WriteLine("1. View directive data");
                    Console.WriteLine("2. View employee data");
                    Console.WriteLine("3. View employee special data");
                    Console.WriteLine("4. Exit");
                    Console.Write("\tEnter option number (1-4): ");
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            d.showCamps();
                            mostrarPasta(d);
                            Console.Write("\tHacienda: " + d.hacienda() + "\n");
                            Console.WriteLine();
                            break;

                        case 2:
                            emp.showCampsEmp();
                            Console.Write("\tHacienda: " + emp.hacienda() + "\n");
                            Console.WriteLine();
                            break;

                        case 3:
                            empE.showCampsEmp(0);
                            mostrarPasta(empE);
                            Console.Write("\tHacienda: " + empE.hacienda() + "\n");
                            break;

                        case 4:
                            exit = true;
                            Console.WriteLine("\tThanks and come back soon");
                            break;

                        default:
                            Console.WriteLine("\tChoose an option to 1 an 4\n");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("\tSorry, enter a option number no a letter\n");
                }
            }
            Console.ReadLine();

        }
    }

    abstract class Persona
    {
        private string nombre;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        private string apellidos;
        public string Apellidos
        {
            set { apellidos = value; }
            get { return apellidos; }
        }

        private int edad;
        public int Edad
        {
            set
            {
                if (value > 0)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }

            get { return edad; }
        }

        private string dni;
        public string Dni
        {
            set
            {
                if (dni != null)
                {
                    dni = value.Substring(0, 8);
                }
            }

            get
            {
                string aux_letter = "";
                string[] letters = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                int calc = Convert.ToInt32(dni) % 23;

                for (int i = 0; i < letters.Length; i++)
                {
                    aux_letter = letters[calc];
                }

                return dni + aux_letter;

            }
        }

        public virtual void introCamps()
        {
            Console.Write("Enter name: ");
            this.Nombre = Console.ReadLine();
            Console.Write("Enter surname: ");
            this.Apellidos = Console.ReadLine();
            Console.Write("Enter age: ");
            this.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter DNI: ");
            this.Dni = Console.ReadLine();
        }

        public virtual void showCamps()
        {
            Console.WriteLine("\tName: " + this.Nombre);
            Console.WriteLine("\tSurname: " + this.Apellidos);
            Console.WriteLine("\tAge: " + this.Edad.ToString());
            Console.WriteLine("\tDNI: " + this.Dni);
        }

        public Persona(string name, string surname, int age, string dni)
        {
            this.Nombre = name;
            this.Apellidos = surname;
            this.Edad = age;
            this.Dni = dni;
        }

        public Persona()
            : this("", "", 0, "")
        {
        }

        public abstract double hacienda();
    }

    class Empleado : Persona
    {
        private double salario;
        public double Salario
        {
            set
            {
                if (value < 600)
                {
                    irpf = 7;
                }
                else if (value < 3000)
                {
                    irpf = 15;
                }
                else
                {
                    irpf = 20;
                }
                salario = value;
            }

            get
            {
                return salario;
            }
        }

        private double irpf;
        public double IRPF
        {
            get { return irpf; }
        }

        private string numeroTelefono;
        public string NumeroTelefono
        {
            set { numeroTelefono = value; }
            get { return "+34" + numeroTelefono; }
        }

        public void showCampsEmp()
        {
            base.showCamps();
            Console.WriteLine("\tSalary: " + this.Salario);
            Console.WriteLine("\tIRPF: " + this.IRPF);
            Console.WriteLine("\tPhone number: " + this.NumeroTelefono);
        }

        public void showCampsEmp(int param)
        {
            switch (param)
            {
                case 0:
                    Console.WriteLine("Name: " + base.Nombre);
                    break;

                case 1:
                    Console.WriteLine("Name: " + base.Apellidos);
                    break;

                case 2:
                    Console.WriteLine("Name: " + base.Edad);
                    break;

                case 3:
                    Console.WriteLine("Name: " + base.Dni);
                    break;

                case 4:
                    Console.WriteLine("Name: " + this.Salario);
                    break;

                case 5:
                    Console.WriteLine("Name: " + this.IRPF);
                    break;

                case 6:
                    Console.WriteLine("Name: " + this.NumeroTelefono);
                    break;
            }
        }

        public override double hacienda()
        {
            return IRPF * Salario / 100;
        }

        public Empleado(string? nombre, string? apellidos, int edad, string? nif, double salary, string? phoneNumber)
        : base()
        {
            this.Salario = salary;
            this.NumeroTelefono = phoneNumber;
        }

        public Empleado()
            : this(null, null, 0, null, 0, null)
        {
        }
    }

    class Directivo : Persona, IPastaGansa
    {
        private double PastaGanada;
        private string nombreDepartamento;
        public string NombreDepartamento
        {
            set { nombreDepartamento = value; }
            get { return nombreDepartamento; }
        }

        private double porcentajeBeneficios;
        public double PorcentajeBeneficios
        {
            get { return porcentajeBeneficios; }
        }

        private int numPersonas;
        public int NumPersonas
        {
            set
            {
                if (value <= 10)
                {
                    porcentajeBeneficios = 0.02;
                }
                else if (value <= 50)
                {
                    porcentajeBeneficios = 0.035;
                }
                else
                {
                    porcentajeBeneficios = 0.04;
                }
                numPersonas = value;
            }

            get
            {
                return numPersonas;
            }
        }


        public Directivo(String nombre, String apellidos, int edad, String dni, String departamento, int personas)
            : base(nombre, apellidos, edad, dni)
        {
            this.NombreDepartamento = departamento;
            this.NumPersonas = personas;
        }
        public void showCamps()
        {
            base.showCamps();
            Console.WriteLine("\tName of the Departament: " + this.nombreDepartamento);
            Console.WriteLine("\tBenefits: " + this.porcentajeBeneficios + "%");
            Console.WriteLine("\tPeople Number: " + this.numPersonas);
        }
        public void introCamps()
        {
            base.introCamps();
            Console.Write("Enter name of the departament: ");
            this.nombreDepartamento = Console.ReadLine();
            Console.Write("Enter number of the people: ");
            this.numPersonas = Convert.ToInt32(Console.ReadLine());
        }

        public static Directivo operator --(Directivo directivo)
        {
            if (directivo.porcentajeBeneficios > 1)
            {
                directivo.porcentajeBeneficios--;
            }
            return directivo;
        }
        public override double hacienda()
        {
            return (PastaGanada * 30) / 100;
            throw new NotImplementedException();
        }

        public double ganarPasta(double beneficiosTotales)
        {
            double ganancias = (PorcentajeBeneficios * beneficiosTotales) / 100;
            if (beneficiosTotales < 0)
            {
                Directivo d = this;
                d--;
                ganancias = 0;
            }
            PastaGanada = ganancias;
            return ganancias;
        }

        
    }

    class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public EmpleadoEspecial(String nombre, String apellidos, int edad, String dni)
            : base()
        {

        }

        public double ganarPasta(double beneficiosTotales)
        {
            return (beneficiosTotales * 0.5) / 100;
        }

        public override double hacienda()
        {
            return ((base.hacienda() * 0.5) / 100) + base.hacienda();
        }
    }

    interface IPastaGansa
    {
        public double ganarPasta(double beneficios);
    }
}