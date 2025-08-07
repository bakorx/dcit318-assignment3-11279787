using WarehouseInventory.Manager;
using WarehouseInventory.Models;

namespace WarehouseInventory
{
    class Program
    {
        static void Main()
        {
            var manager = new WarehouseManager();
            manager.SeedData();

            Console.WriteLine("Grocery Items:");
            manager.PrintAllItems(manager.GetGroceries());

            Console.WriteLine("\nElectronic Items:");
            manager.PrintAllItems(manager.GetElectronics());

            // Add duplicate
            Console.WriteLine("\n[Testing Duplicate Add]");
            try
            {
                manager.GetElectronics().AddItem(new ElectronicItem(1, "TV", 3, "LG", 18));
            }
            catch (DuplicateItemException ex)
            {
                Console.WriteLine($"[Error]: {ex.Message}");
            }

            // Remove non-existent
            Console.WriteLine("\n[Testing Remove Non-existent]");
            manager.RemoveItemById(manager.GetGroceries(), 999);

            // Invalid quantity
            Console.WriteLine("\n[Testing Invalid Quantity Update]");
            try
            {
                manager.GetElectronics().UpdateQuantity(2, -5);
            }
            catch (InvalidQuantityException ex)
            {
                Console.WriteLine($"[Error]: {ex.Message}");
            }

            Console.WriteLine("\nEnd of Inventory Management.");
        }
    }
}
