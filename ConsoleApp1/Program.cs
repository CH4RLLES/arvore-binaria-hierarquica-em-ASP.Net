class Program
{
    public static void Main(string[] args)
    {
        Arvore();
        Console.ReadKey();

    }

    public static void Arvore()
    {
        Pessoa P1 = new Pessoa("A");
        Pessoa P2 = new Pessoa("B");
        Pessoa P3 = new Pessoa("C");
        Pessoa P4 = new Pessoa("D");
        Pessoa P5 = new Pessoa("E");
        Pessoa P6 = new Pessoa("F");
        Pessoa P7 = new Pessoa("G");
        Pessoa P8 = new Pessoa("H");

        P1.Filhos.AddRange(new[] {P2, P3});
        P2.Filhos.AddRange(new[] {P4, P7});
        P3.Filhos.AddRange(new[] {P5, P8});
        P5.Filhos.Add(P6);
        

        Console.WriteLine("\n Mostrar a avore \n");
        PrintArvore(P1, 0);
    }

    

    private static void PrintArvore(Pessoa nd, int level)
    {
        
        if (nd != null)
        {
            Console.WriteLine(IncluirSpace(level) + nd.Nome);
            level++;
            foreach (var item in nd.Filhos)
            {
                PrintArvore(item, level);
            }
        }
    }

    static string IncluirSpace(int level)
    {
        string space = "";
        for (int i = 0; i < level; i++)
        {
            space += "  ";
        }
        return space;
    }

    public class Pessoa
    {
        public string Nome = string.Empty;
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public List<Pessoa> Filhos = new List<Pessoa>();
    }
}