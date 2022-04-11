class Program
{
    public static void Main(string[] args)
    {
        ManagePersonTree();
        Console.ReadKey();

    }

    public static void ManagePersonTree()
    {
        Person P1 = new Person("A");
        Person P2 = new Person("B");
        Person P3 = new Person("C");
        Person P4 = new Person("D");
        Person P5 = new Person("E");
        Person P6 = new Person("F");
        Person P7 = new Person("G");
        Person P8 = new Person("H");

        P1.Childs.AddRange(new[] {P2, P3});
        P2.Childs.AddRange(new[] {P4, P7});
        P3.Childs.AddRange(new[] {P5, P8});
        P5.Childs.Add(P6);
        

        Console.WriteLine("\n Mostrar a avore \n");
        PrintFamilyTree(P1, 0);
    }

    

    private static void PrintFamilyTree(Person nd, int level)
    {
        
        if (nd != null)
        {
            Console.WriteLine(GetSpace(level) + nd.Name);
            level++;
            foreach (var item in nd.Childs)
            {
                PrintFamilyTree(item, level);
            }
        }
    }

    static string GetSpace(int level)
    {
        string space = "";
        for (int i = 0; i < level; i++)
        {
            space += "  ";
        }
        return space;
    }

    public class Person
    {
        public string Name = string.Empty;
        public Person(string name)
        {
            Name = name;
        }
        public List<Person> Childs = new List<Person>();
    }
}