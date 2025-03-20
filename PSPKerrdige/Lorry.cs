namespace PSPKerrdige
{
    public class Lorry
    {
        // Attributes
        public float WeightCapacity { get; set; }
        public float Lorry_ID { get; set; }
        public float VolumeCapacity { get; set; }

        public List<Item> LoadedItems { get; set; } = new List<Item>();

        private float CurrentWeight = 0; 
        private float CurrentVolume = 0; 

        // Constructor
        public Lorry(float capacity, float lorry_ID, float weightCapacity, float volumeCapacity)
        {
            WeightCapacity = weightCapacity;
            Lorry_ID = lorry_ID;
            VolumeCapacity = volumeCapacity;
        }

        public float RemainingCapacity()
        {
            return WeightCapacity - CurrentWeight;
        }

        public float RemainingVolume()
        {
            return VolumeCapacity - CurrentVolume; 
        }
        
        public bool MoveItem(Item item)
        {
            // Check if the item fits in weight and volume
            if (RemainingCapacity() >= item.Weight && RemainingVolume() >= item.Volume)
            {
                LoadedItems.Add(item);
                CurrentWeight += item.Weight;
                CurrentVolume += item.Volume; 
                return true;
            }
            return false;
        }

        // Remove an item from the lorry and update totals
        public void RemoveItem(Item item)
        {
            if (LoadedItems.Remove(item))
            {
                CurrentWeight -= item.Weight;
                CurrentVolume -= item.Volume; 
            }
        }
        
        public int CountItems()
        {
            return LoadedItems.Count;
        }

        public string DisplayResults()
        {
            if (LoadedItems.Count > 0)
            {
                return "Lorry " + Lorry_ID + ": \n Weight remaining: " + RemainingCapacity() + "KG\n Volume remaining: " + RemainingVolume() + "CM^3\n Items: \n" + string.Join(", ", LoadedItems.Select(item => item.Count_ID)) + "\n Total Items: " + CountItems();
            }
            else
            {
                return "Lorry " + Lorry_ID + " is empty";
            }
        }
    }
}