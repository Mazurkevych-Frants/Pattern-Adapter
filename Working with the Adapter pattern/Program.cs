using Working_with_the_Adapter_pattern.Classes;

public static class Program
{
    public static void Main()
    {
        var xml = new XmlFormat();
        var adapter = new XmlToJsonAdapter(xml);

        xml.GetXml();

        Console.WriteLine();

        adapter.GetJson();
    }
}