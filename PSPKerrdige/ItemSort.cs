namespace PSPKerrdige;
using System;
using System.Collections.Generic;
using System.Linq;

public class ItemSort
{
    // Create a list of lorries and items
    public List<Lorry> Lorries { get; set; } = new List<Lorry>();
    public List<Item> Items { get; set; } = new List<Item>();

    public void FirstFitDecreasing(float Weight, float Volume)
    {
        // Sort the items by weight in descending order
        Items = Items.OrderByDescending(Item => Item.Weight).ToList();
        
        // Loop through each item
        foreach (Item Item in Items)
        {
            // Create a boolean to check if the item has been placed
            bool Placed = false;

            // Loop through each lorry
            foreach (Lorry Lorry in Lorries)
            {
                // If the item can be move into a lorry place it and set Placed to true
                if (Lorry.MoveItem(Item))
                {
                    Placed = true;
                   break;
                }
            }

            // If the item has not been placed create a new lorry and move the item into it
            if (!Placed)
            {
                Lorry NewLorry = new Lorry(0, Lorries.Count + 1, Weight, Volume);
                // Move the item into the new lorry
                NewLorry.MoveItem(Item);
                Lorries.Add(NewLorry);
            }
        }
    }

    public string DisplayResults()
    {
        // Console.WriteLine("Total Lorries Used: " + Lorries.Count);
        string result = "";
        foreach (Lorry Lorry in Lorries)
        {
            result += Lorry.DisplayResults() + "\n";
        }
        return result;
    }
}