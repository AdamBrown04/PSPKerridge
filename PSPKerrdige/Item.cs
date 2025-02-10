namespace PSPKerrdige;

public class Item
{
    public float Mass { get; set; }
    public float Volume { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public static List<Item> Items = new List<Item>();

    public Item(float mass, float volume, float width, float height, string name, string type)
    {
        Mass = mass;
        Volume = volume;
        Width = width;
        Height = height;
        Name = name;
        Type = type;
    }

    public string PrintItem()
    {
        return $"{Name} Type: {Type} Mass: {Mass} Volume: {Volume} Width: {Width} Height: {Height}";
    }
}