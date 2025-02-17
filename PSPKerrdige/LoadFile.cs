using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PSPKerrdige
{
    public class LoadFile
    {
        public static List<Item> LoadItemsFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            var itemDataList = JsonSerializer.Deserialize<List<ItemData>>(jsonString) ?? new List<ItemData>();
            return ConvertItems(itemDataList);
        }//

        private static List<Item> ConvertItems(List<ItemData> itemDataList)
        {
            List<Item> items = new List<Item>();
            foreach (var data in itemDataList)
            {
                items.Add(new Item(
                    int.Parse(data.Count_ID ?? "0"),
                    float.Parse(data.Height ?? "0"),
                    float.Parse(data.Length ?? "0"),
                    float.Parse(data.SurfaceArea ?? "0"), data.Type ?? string.Empty,
                    float.Parse(data.Volume ?? "0"),
                    float.Parse(data.Weight ?? "0"),
                    float.Parse(data.Width ?? "0")
                ));
            }
            return items;
        }
    }

    public class ItemData
    {
        public string Count_ID { get; set; }
        public string Height { get; set; }
        public string Length { get; set; }
        public string SurfaceArea { get; set; }
        public string Type { get; set; }
        public string Volume { get; set; }
        public string Weight { get; set; }
        public string Width { get; set; }
    }
}