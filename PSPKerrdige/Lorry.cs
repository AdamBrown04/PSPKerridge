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

        // Extra space between items as 5% of the volume

        public float SpaceBetween { get; set; } = 1.05f;

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
            // Check if the item fits considering weight and effective volume (including extra space).
            if (RemainingCapacity() >= item.Weight && RemainingVolume() >= item.Volume * SpaceBetween)
            {
                LoadedItems.Add(item);
                CurrentWeight += item.Weight;
                CurrentVolume += item.Volume * SpaceBetween;
                return true;
            }

            return false;
        }

        // Remove an item and update totals accordingly.
        public void RemoveItem(Item item)
        {
            if (LoadedItems.Remove(item))
            {
                CurrentWeight -= item.Weight;
                CurrentVolume -= item.Volume * SpaceBetween;
            }
        }

//
        public string DisplayResults()
        {
            if (LoadedItems.Count > 0)
            {
                float VolumeMeters = RemainingVolume() / 1000000f;

                return "Lorry " + Lorry_ID + ": \n" +
                       "Weight remaining: " + RemainingCapacity() + " KG\n" +
                       "Volume remaining: " + VolumeMeters.ToString("F5") + " M³\n" +
                       "Items: \n" + string.Join(", ", LoadedItems.Select(item => item.Count_ID));
            }
            else
            {
                return "Lorry " + Lorry_ID + " is empty";
            }
        }
    }
} //