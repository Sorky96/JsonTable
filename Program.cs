

using JsonTable;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n Podaj sciezke do pliku");
        var path = Console.ReadLine();

        if (path == null || !File.Exists(path))
        {
            Console.WriteLine("Not a valid path");
            Console.ReadKey();
        }
        else
        {
            var jsonHelper = new JsonHelper();
            var jsonObject = jsonHelper.GetJsonObject(path);
            var tableGenerator = new TableGenerator();
            tableGenerator.GenerateTable(jsonObject);

            Console.WriteLine("Again? Y/N");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Main(new string[0]);
            }

            Console.ReadLine();
        }

    }
}
