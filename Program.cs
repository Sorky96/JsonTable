

using JsonTable;

public class Program
{
    public static void Main(string[] args)
    {
        var jsonHelper = new JsonHelper();
        var jsonObject = jsonHelper.GetJsonObject("example.json");
        var tableGenerator = new TableGenerator();
        tableGenerator.GenerateTable(jsonObject);
        Console.ReadLine();
    }
}
