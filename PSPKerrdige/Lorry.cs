namespace PSPKerrdige;

public class Lorry
{
    public float WeightCapacity { get; set; }
    public float Lorry_ID { get; set; }
    public float VolumeCapacity { get; set; }
    
    
    public List<Item> LoadedItems { get; set; } = new List<Item>();

    public Lorry(float capacity, float lorry_ID, float Weightcapacity, float volumeCapacity)
    {
        WeightCapacity = Weightcapacity;
        Lorry_ID = lorry_ID;
        VolumeCapacity = volumeCapacity;
        
    }

    public float RemainingCapacity()
    {
        return LoadedItems.Sum(item => item.Weight);
    }

    public float RemainingVolume()
    {
        return LoadedItems.Sum(item => item.Volume);
    }

    public bool MoveItem(Item item)
    {
        if (RemainingCapacity() + item.Weight <= WeightCapacity && RemainingVolume() + item.Volume <= VolumeCapacity)
        {
            LoadedItems.Add(item);
            return true;
        }
        return false;
    }

    public void RemoveItem(Item item)
    {
        LoadedItems.Remove(item);
    }

public string DisplayResults()
{
    if (LoadedItems.Count > 0)
    {
        return "Lorry " + Lorry_ID + ": " + string.Join(", ", LoadedItems.Select(item => + item.Count_ID));
    }
        else
        {
            return "Lorry " + Lorry_ID + " is empty";
        }
}
    
    
}