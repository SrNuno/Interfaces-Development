namespace EntireNewsletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream

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

=======
            /*Persona persona = new Persona();
            persona.introCamps();
            persona.showCamps();*/
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

>>>>>>> Stashed changes
    private int age;
    public int Age
    {
        set
        {
<<<<<<< Updated upstream
            if (age > 0)
            {
                age = value;

=======
            if (value > 0)
            {
                age = value;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        Console.Write("Enter DNI any letter: ");
=======
        Console.Write("Enter DNI: ");
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
    public abstract double hacienda()
    {
        return 0.0;
    }
=======
    public abstract double hacienda();
>>>>>>> Stashed changes
}

class Empleado : Persona
{
    private double salary;
    public double Salary
    {
        set
        {
<<<<<<< Updated upstream
            if (salary < 600)
            {
                irpf = 7;
            }
            else if (salary < 3000)
            {
                irpf = 15;
            }
            else
            {
                irpf = 20;
            }
        }

        get { return salary; }
    }

    private double irpf;
    public double IRPF
    {
        get { return irpf; }
    }

    private string phoneNumber;
    public string PhoneNumber
    {
        get { return "+34" + phoneNumber; }
    }

    public void showCampsEmp()
    {
        base.showCamps();
        Console.WriteLine("Salary: " + this.Salary);
        Console.WriteLine("IRPF: " + this.IRPF);
        Console.WriteLine("Phone number: " + this.PhoneNumber);
    }

    public void showCampsEmp(int param)
    {
        switch (param)
        {
            case 0:
                Console.WriteLine("Name: " + base.Name);
                break;

            case 1:
                Console.WriteLine("Name: " + base.Surname);
                break;

            case 2:
                Console.WriteLine("Name: " + base.Age);
                break;

            case 3:
                Console.WriteLine("Name: " + base.Dni);
                break;

            case 4:
                Console.WriteLine("Name: " + this.Salary);
                break;

            case 5:
                Console.WriteLine("Name: " + this.IRPF);
                break;

            case 6:
                Console.WriteLine("Name: " + this.PhoneNumber);
                break;
=======
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
        }

        get { return salary; }
    }

    private double irpf;
    public double IRPF
    {
        get { return irpf; }
    }

    private string phoneNumber;
    public string PhoneNumber
    {
        get { return "+34" + phoneNumber; }
    }

    public void showCampsEmp()
    {
        base.showCamps();
        Console.WriteLine("Salary: " + this.Salary);
        Console.WriteLine("IRPF: " + this.IRPF);
        Console.WriteLine("Phone number: " + this.PhoneNumber);
    }

    public void showCampsEmp(int param)
    {
        switch (param)
        {
            case 0:
                Console.WriteLine("Name: " + Name);
                break;

            case 1:
                Console.WriteLine("Surname: " + Surname);
                break;

            case 2:
                Console.WriteLine("Age: " + Age);
                break;

            case 3:
                Console.WriteLine("DNI: " + Dni);
                break;

            case 4:
                Console.WriteLine("Salary: " + this.Salary);
                break;

            case 5:
                Console.WriteLine("IRPF: " + this.IRPF);
                break;

            case 6:
                Console.WriteLine("Phone Number: " + this.PhoneNumber);
                break;
        }
    }

    public override double hacienda()
    {
        return IRPF * Salary / 100;
    }

    public Empleado(double salary, double irpf, string phoneNumber)
        : base()
    {
        Salary = salary;
        this.irpf = irpf;
        this.phoneNumber = phoneNumber;
    }

    public Empleado()
        : this(0, 0, null)
    {
    }
}

class Directivo : Persona, IPastaGana
{
    public string departamentName;
    private int peopleNumber;
    public double benefits;
    public int PeopleNumber
    {
        set
        {
            if (value <= 10)
            {
                benefits = 2;
            }
            else if (value <= 50)
            {
                benefits = 3.5;
            }
            else
            {
                benefits = 4;
            }
        }
    }

    public static Directivo operator --(Directivo directivo)
    {
        if (directivo.benefits > 1)
        {
            directivo.benefits--;
        }
        return directivo;
    }

    public void showCamps()
    {
        base.showCamps();
        Console.WriteLine("Name of the Departament: " + this.departamentName);
        Console.WriteLine("Benefits: " + this.benefits);
        Console.WriteLine("People Number: " + this.peopleNumber);
    }

    public void introCamps()
    {
        base.introCamps();
        Console.Write("Enter name of the departament: ");
        this.departamentName = Console.ReadLine();
        Console.Write("Enter number of the people: ");
        this.peopleNumber = Convert.ToInt32(Console.ReadLine());
    }

    public double winMoney(double benefitsTotals)
    {
        if (benefitsTotals < 0)
        {
            Directivo d = this;
            d--;
>>>>>>> Stashed changes
        }
        return
    }
<<<<<<< Updated upstream

    public override double hacienda()
    {
        return IRPF * Salary / 100;
    }

    public Empleado(double salary, double irpf, string phoneNumber)
    {
        Salary = salary;
        this.irpf = irpf;
        this.phoneNumber = phoneNumber;
    }
}
=======
}
interface IPastaGana
{
    public double winMoney(double benefitsTotals);
}
>>>>>>> Stashed changes
