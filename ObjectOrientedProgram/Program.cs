using ObjectOrientedProgram.Repository;

namespace ObjectOrientedProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Object Oriented Program");

            InventoryManager inventoryManager = new InventoryManager();
            inventoryManager.CalcInventoryValue();

        }
    }
}