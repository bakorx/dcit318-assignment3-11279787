using InventorySystem.App;

class Program
{
    static void Main()
    {
        var app = new InventoryApp();

        app.SeedSampleData();
        app.SaveData();

        Console.WriteLine("Saved inventory. Simulating a new session...\n");

        var newApp = new InventoryApp();
        newApp.LoadData();
        newApp.PrintAllItems();
    }
}
