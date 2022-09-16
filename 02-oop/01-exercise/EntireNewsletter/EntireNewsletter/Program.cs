namespace EntireNewsletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Dni = "";
            Console.WriteLine(persona.Dni);
        }
    }

    class Persona
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        private string surname;
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }

        private int age;
        public int Age
        {
            set
            {
                if (age > 0)
                {
                    age = value;

                }
                else
                {
                    age = 0;
                }
            }
            get { return age; }
        }

        private string dni;
        public string Dni
        {
            set
            {
                if (dni == null)
                {
                    dni = "Error";
                }
            }
            get
            {
                string letter = "";
                string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                try
                {
                    int calc = Convert.ToInt32(dni) % 23;

                    for (int i = 0; i < control.Length; i++)
                    {
                        letter = control[calc];
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, DNI invalid");
                }
                return dni + letter;

            }
        }
    }
}