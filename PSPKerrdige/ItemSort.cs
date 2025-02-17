namespace PSPKerrdige;

public class ItemSort
{
    public List<Lorry> Lorries { get; set; } = new List<Lorry>();
    public List<Item> Items { get; set; } = new List<Item>();
    private Stack<(Item Item, Lorry SourceLorry, Lorry DestinationLorry)> MoveStack = new Stack<(Item, Lorry, Lorry)>();

    public int FitnessFunction()
    {
        return Lorries.Count(Lorry => Lorry.LoadedItems.Count > 0);
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
            (Item Item, Lorry SourceLorry, Lorry DestinationLorry) LastMove = MoveStack.Pop();
            LastMove.DestinationLorry.RemoveItem(LastMove.Item);
            LastMove.SourceLorry.MoveItem(LastMove.Item);
        }
    }

    public int HillClimbing(int Iterations)
    {
        int TotalFitnessValue = FitnessFunction();
        for (int i = 0; i < Iterations; i++)
        {
            MoveSelectedItem();
            int NewFitnessValue = FitnessFunction();
            if (NewFitnessValue > TotalFitnessValue)
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