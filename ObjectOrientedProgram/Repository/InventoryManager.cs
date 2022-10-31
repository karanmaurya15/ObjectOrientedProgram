using Newtonsoft.Json;
using ObjectOrientedProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.Repository
{
    internal class InventoryManager
    {

        public string FilePath = @"C:\Bridgelabz classes\ObjectOrientedProgram\ObjectOrientedProgram\JSONFile\InventoryData.json";

        public void CalcInventoryValue()
        {
            var jsonData = File.ReadAllText(FilePath);
            var inventoryData = JsonConvert.DeserializeObject<InventoryModel>(jsonData);

            Console.WriteLine(
                inventoryData.Rice.Name + "\n" +
                inventoryData.Rice.Weight + "\n" +
                inventoryData.Rice.PricePerKG
                + "\n" +
                inventoryData.Pulses.Name + "\n" +
                inventoryData.Pulses.Weight + "\n" +
                inventoryData.Pulses.PricePerKG
                + "\n" +
                inventoryData.Wheats.Name + "\n" +
                inventoryData.Wheats.Weight + "\n" +
                inventoryData.Wheats.PricePerKG
                );

            int totalValueForRice = inventoryData.Rice.PricePerKG * inventoryData.Rice.Weight;
            int totalValueForPulses = inventoryData.Pulses.PricePerKG * inventoryData.Pulses.Weight;
            int totalValueForWheats = inventoryData.Wheats.PricePerKG * inventoryData.Wheats.Weight;

            Console.WriteLine($"\nTotal Value For Rice in Rs.   ::{totalValueForRice}");
            Console.WriteLine($"Total Value For Pulses in Rs. ::{totalValueForPulses}");
            Console.WriteLine($"Total Value For Wheats in Rs. ::{totalValueForWheats}");

            Console.WriteLine("Data" + jsonData);
            Console.ReadLine();
           
        }
    }
}
