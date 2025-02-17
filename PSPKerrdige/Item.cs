using System.Text.Json.Serialization;

public class Item
{
    public int Count_ID { get; set; }
    public float Height { get; set; }
    public float Length { get; set; }
    public float SurfaceArea { get; set; }
    public string Type { get; set; }
    public float Volume { get; set; }
    public float Weight { get; set; }
    public float Width { get; set; }
    
    public Item(int count_ID, float height, float length, float surfaceArea, string type, float volume, float weight, float width)
    {
        Count_ID = count_ID;
        Height = height;
        Length = length;
        SurfaceArea = surfaceArea;
        Type = type;
        Volume = volume;
        Weight = weight;
        Width = width;
    }
}
