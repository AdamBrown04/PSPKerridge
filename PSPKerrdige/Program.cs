using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

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
            ApplicationConfiguration.Initialize();

            try
            {
                var items = LoadFile.LoadItemsFromJson("Data/datafile.json");
                if (items == null)
                {
                    throw new Exception("Deserialized items are null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Run(new HomeForm());
        }
    }
}