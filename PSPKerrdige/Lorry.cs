namespace PSPKerrdige;

public class Lorry
{
    //attributes
    public float WeightCapacity { get; set; }
    public float Lorry_ID { get; set; }
    public float VolumeCapacity { get; set; }
    public List<Item> LoadedItems { get; set; } = new List<Item>();
    //constructor
    public Lorry(float capacity, float lorry_ID, float Weightcapacity, float volumeCapacity)
    {
        WeightCapacity = Weightcapacity;
        Lorry_ID = lorry_ID;
        VolumeCapacity = volumeCapacity;
        
    }
    //methods
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
        // Check if the item can be moved into the lorry by checking if the weight and volume of the item is less than the remaining capacity and volume of the lorry
        if (RemainingCapacity() + item.Weight <= WeightCapacity && RemainingVolume() + item.Volume <= VolumeCapacity)
        {
            // Add the item to the lorry and return true
            LoadedItems.Add(item);
            return true;
        }
        return false;
    }

    // Remove an item from the lorry
    public void RemoveItem(Item item)
    {
        // Removes the item from the lorry
        LoadedItems.Remove(item);
    }

    public string DisplayResults()
    {
        // Display the results of the items inside each lorry
        if (LoadedItems.Count > 0)
        {
            return "Lorry " + Lorry_ID + ": \n" + string.Join(", ", LoadedItems.Select(item => + item.Count_ID));
        }
        else
        {
            return "Lorry " + Lorry_ID + " is empty";
        }   
    }
}