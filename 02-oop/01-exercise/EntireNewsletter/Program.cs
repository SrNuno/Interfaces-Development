namespace EntireNewsletter
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

abstract class Persona
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
            dni = value.Substring(0, 8);
        }

        get
        {
            string letter = "";
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            int calc = Convert.ToInt32(dni) % 23;

            for (int i = 0; i < control.Length; i++)
            {
                letter = control[calc];
            }

            return dni + letter;
        }

    }
    public virtual void introCamps()
    {
        Console.Write("Enter name: ");
        this.Name = Console.ReadLine();
        Console.Write("Enter surname: ");
        this.Surname = Console.ReadLine();
        Console.Write("Enter age: ");
        this.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter DNI any letter: ");
        this.Dni = Console.ReadLine();
    }

    public virtual void showCamps()
    {
        Console.WriteLine("Name: " + this.Name);
        Console.WriteLine("Surname: " + this.Surname);
        Console.WriteLine("Age: " + this.Age.ToString());
        Console.WriteLine("DNI: " + this.Dni);
    }

    public Persona(string name, string surname, int age, string dni)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.Dni = dni;
    }

    public Persona()
        : this("", "", 0, "")
    {
    }

    abstract double hacienda()
    {
        return 0.0;
    }
}