namespace PSPKerrdige;

public class ItemSwap
{
    // Create a list of items and lorries and a stack to store moves
    public List<Lorry> Lorries { get; set; } = new List<Lorry>();
    public List<Item> Items { get; set; } = new List<Item>();

    private Stack<(Item Item, Lorry SourceLorry, Lorry DestinationLorry)> MoveStack = new Stack<(Item, Lorry, Lorry)>();

    // Create a random object to select random items and lorries
    private Random Random = new Random();

    public float FitnessFunction()
    {
        // Return the sum of the volume of all items in all lorries as the fitness function
        // This is what compares whether a move is an improvement or not
        return Lorries.Sum(lorry => lorry.LoadedItems.Sum(item => item.Volume));
    }

    public void MoveSelectedItem()
    {
        // Select a random item and the lorry it is in
        Item SelectedItem = Items[Random.Next(Items.Count)];
        // Find the lorry the item is in and set it as the source lorry
        Lorry SourceLorry = Lorries.First(Lorry => Lorry.LoadedItems.Contains(SelectedItem));

        // Find a random lorry that is not the source lorry and set it as the destination lorry
        Lorry DestinationLorry;
        do
        {
            DestinationLorry = Lorries[Random.Next(Lorries.Count)];
        } while (DestinationLorry == SourceLorry);

        // Move the item from the source lorry to the destination lorry
        if (DestinationLorry.MoveItem(SelectedItem))
        {
            // Remove the item from the source lorry and add the move to the stack
            SourceLorry.RemoveItem(SelectedItem);
            MoveStack.Push((SelectedItem, SourceLorry, DestinationLorry));
        }
    }

    public void Backtrack()
    {
        // If there are moves in the stack pop the last move and undo it
        if (MoveStack.Count > 0)
        {
            (Item item, Lorry sourceLorry, Lorry destinationLorry) = MoveStack.Pop();
            destinationLorry.RemoveItem(item);
            sourceLorry.MoveItem(item);
        }
    }

    public float HillClimbing(int Iterations, IProgress<int> ProgessPercent = null)
    {
        float TotalFitnessValue = FitnessFunction();
        for (int i = 0; i < Iterations; i++)
        {
            // Perform a single optimization move.
            MoveSelectedItem();
            float NewFitnessValue = FitnessFunction();

            if (NewFitnessValue < TotalFitnessValue)
            {
                Backtrack();
            }
            else
            {
                TotalFitnessValue = NewFitnessValue;
            }

            if (ProgessPercent != null && i % 100 == 0)
            {
                ProgessPercent.Report((i * 100) / Iterations);
            }
        }

        return TotalFitnessValue;
    }
}