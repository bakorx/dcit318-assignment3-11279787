using InventorySystem.Models;
using InventorySystem.Services;

namespace InventorySystem.App
{
    public class InventoryApp
    {
        private InventoryLogger<InventoryItem> _logger;

        public InventoryApp()
        {
            _logger = new InventoryLogger<InventoryItem>("inventory.json");
        }

        public void SeedSampleData()
        {
            _logger.Add(new InventoryItem(1, "Printer", 10, DateTime.Now));
            _logger.Add(new InventoryItem(2, "Monitor", 7, DateTime.Now));
            _logger.Add(new InventoryItem(3, "Laptop", 3, DateTime.Now));
            _logger.Add(new InventoryItem(4, "Keyboard", 12, DateTime.Now));
            _logger.Add(new InventoryItem(5, "Mouse", 15, DateTime.Now));
        }

        public void SaveData()
        {
            _logger.SaveToFile();
        }

        public void LoadData()
        {
            _logger.LoadFromFile();
        }

        public void PrintAllItems()
        {
            foreach (var item in _logger.GetAll())
            {
                Console.WriteLine($"ID: {item.Id} | Name: {item.Name} | Qty: {item.Quantity} | Date: {item.DateAdded}");
            }
        }
    }
}
