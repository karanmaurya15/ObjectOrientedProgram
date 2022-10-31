using Newtonsoft.Json;
using ObjectOrientedProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.Repository
{
    public class InventoryManager
    {
        public string FilePath = @"C:\Bridgelabz classes\ObjectOrientedProgram\ObjectOrientedProgram\JSONFile\InventoryData.json";

        public void CalcInventoryValue()
        {
            var jsonData = File.ReadAllText(FilePath);
            var inventoryData = JsonConvert.DeserializeObject<InventoryModel>(jsonData);

            foreach (var Rice in inventoryData.Rice)
            {
                Console.WriteLine( Rice.Name + "\t" +  Rice.Weight + "\t" + Rice.PricePerKG );
                Console.WriteLine($"Total Price of {Rice.Name} is : Rs.    {Rice.PricePerKG * Rice.Weight}");
            }

            foreach (var Pulses in inventoryData.Pulses)
            {
                Console.WriteLine( Pulses.Name + "\t" + Pulses.Weight + "\t" + Pulses.PricePerKG);
                Console.WriteLine($"Total Price of {Pulses.Name} is : Rs. {Pulses.PricePerKG * Pulses.Weight}");
            }
            foreach (var Wheats in inventoryData.Wheats)
            {
                Console.WriteLine( Wheats.Name + "\t" + Wheats.Weight + "\t" + Wheats.PricePerKG );
                Console.WriteLine($"Total Price of {Wheats.Name} is : Rs. {Wheats.PricePerKG * Wheats.Weight}");
            }

            Console.WriteLine("Data" + jsonData);
            Console.ReadLine();
           
        }
    }
}
