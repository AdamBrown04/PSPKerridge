namespace PSPKerrdige;
using System;
using System.Collections.Generic;
using System.Linq;

public class ItemSort
{
    public List<Lorry> Lorries { get; set; } = new List<Lorry>();
    public List<Item> Items { get; set; } = new List<Item>();

    public void FirstFitDecreasing(float Weight, float Volume)
    {
        Items = Items.OrderByDescending(Item => Item.Volume).ToList();

        foreach (Item Item in Items)
        {
            bool Placed = false;

            foreach (Lorry Lorry in Lorries)
            {
                if (Lorry.MoveItem(Item))
                {
                    Placed = true;
                    break;
                }
            }

            if (!Placed)
            {
                Lorry NewLorry = new Lorry(0, Lorries.Count + 1, Weight, Volume);
                NewLorry.MoveItem(Item);
                Lorries.Add(NewLorry);
            }
        }
    }

    public string DisplayResults()
    {
        string result = "";
        foreach (Lorry Lorry in Lorries)
        {
            result += Lorry.DisplayResults() + "\n";
        }
        return result;
    }

    public string DisplayTotalLorries()
    {
        return Lorries.Count.ToString();
    }
}