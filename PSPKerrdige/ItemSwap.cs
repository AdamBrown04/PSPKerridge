namespace PSPKerrdige;

public class ItemSwap
{
    public List<Lorry> Lorries { get; set; } = new List<Lorry>();
    public List<Item> Items { get; set; } = new List<Item>();
    private Stack<(Item Item, Lorry SourceLorry, Lorry DestinationLorry)> MoveStack = new Stack<(Item, Lorry, Lorry)>();

    public float FitnessFunction()
    {
        return Lorries.Sum(lorry => lorry.LoadedItems.Sum(item => item.Volume));
    }

    public void MoveSelectedItem()
    {
        Random Random = new Random();
        Item SelectedItem = Items[Random.Next(Items.Count)];
        Lorry SourceLorry = Lorries.First(Lorry => Lorry.LoadedItems.Contains(SelectedItem));

        Lorry DestinationLorry;
        do
        {
            DestinationLorry = Lorries[Random.Next(Lorries.Count)];
        } while (DestinationLorry == SourceLorry);

        if (DestinationLorry.MoveItem(SelectedItem))
        {
            SourceLorry.RemoveItem(SelectedItem);
            MoveStack.Push((SelectedItem, SourceLorry, DestinationLorry));
        }
    }

    public void Backtrack()
    {
        if (MoveStack.Count > 0)
        {
            var LastMove = MoveStack.Pop();
            LastMove.DestinationLorry.RemoveItem(LastMove.Item);
            LastMove.SourceLorry.MoveItem(LastMove.Item);
        }
    }

    public float HillClimbing(int Iterations)
    {
        float TotalFitnessValue = FitnessFunction();
        for (int i = 0; i < Iterations; i++)
        {
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
        }
        return TotalFitnessValue;
    }
}