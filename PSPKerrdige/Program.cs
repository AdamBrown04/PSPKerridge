namespace PSPKerrdige
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }

        static void LoadItems()
        {
            string FileName = "Items.txt";
            Item.Items.Clear();

            using (StreamReader Sr = new StreamReader(FileName))
            {
                while (!Sr.EndOfStream)
                {
                    string[] ItemData = Sr.ReadLine().Split(' ');

                    float Mass = Convert.ToSingle(ItemData[0]);
                    float Volume = Convert.ToSingle(ItemData[1]);
                    float Width = Convert.ToSingle(ItemData[2]);
                    float Height = Convert.ToSingle(ItemData[3]);
                    string Name = ItemData[4];
                    string Type = ItemData[5];

                    Item.Items.Add(new Item(Mass, Volume, Width, Height, Name, Type));
                }
            }
        }
    }
}