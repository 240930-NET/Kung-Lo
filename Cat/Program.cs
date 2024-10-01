namespace Cat;

class Program
{
    static void Main(string[] args)
    {
        Menu.Welcome();

        string? answer = Console.ReadLine();

        if(IsCat(answer)) Console.WriteLine(@"Correct
            |\__/,|   (`\
            |_ _  |.--.) )
            ( T   )     /
          (((^_(((/(((_/");
        else Console.WriteLine("Wrong");
        
    }

    public static bool IsCat(string? answer)
    {
        if(answer?.ToLower() == "cat") return true;
        return false;
    }
}
