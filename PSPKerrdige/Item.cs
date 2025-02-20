using System.Text.Json.Serialization;

public class Item
{
    //attributes
    public int Count_ID { get; set; }
    public int Count_Id { get; set; }
    public float Height { get; set; }
    public float Length { get; set; }
    public float SurfaceArea { get; set; }
    public string Type { get; set; }
    public float Volume { get; set; }
    public float Weight { get; set; }
    public float Width { get; set; }
    //constructor
    public Item(int count_ID, int Count_Id , float height, float length, float surfaceArea, string type, float volume, float weight, float width)
    {
        Count_ID = count_ID;
        this.Count_Id = Count_Id;
        Height = height;
        Length = length;
        SurfaceArea = surfaceArea;
        Type = type;
        Volume = volume;
        Weight = weight;
        Width = width;
        CorrectID();
    }
    //methods
    /*
     This method is used as within the given data set part of the data has a different heading of Count_ID and Count_Id,
     this method is used to correct the ID to be the same.
    */
    public void CorrectID()
    {
        if (Count_ID < Count_Id)
        {
            Count_ID = Count_Id;
        }
    }
}
