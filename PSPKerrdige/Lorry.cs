namespace PSPKerrdige;

public class Lorry
{
    public float Capacity { get; set; }
    public float Lorry_ID { get; set; }
    public List<Item> LoadedItems { get; set; } = new List<Item>();

    public Lorry(float capacity, float lorry_ID)
    {
        Capacity = capacity;
        Lorry_ID = lorry_ID;
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
        if (RemainingCapacity() + item.Weight <= Capacity && RemainingVolume() + item.Volume <= Capacity)
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
}