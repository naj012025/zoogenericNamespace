using zoogenerics.Interface;

namespace zoogenerics.Classes;

public class ZooFeeder
{
    public static void Feed<T>(IAnimalPopper<T> animals)

    where T : Animal
    {
        for (int i = 0; i < animals.Count; i++)
        {
            var animal = animals.Pop();

            var food = animal.Consumption switch
            {
                FoodConsumption.Herbivore => " a fresh salad.",
                FoodConsumption.Carnivore => " a juicy Steak",
                FoodConsumption.Omnivore => "Anything",
                _ => "this type doenst exist"
            };

            Console.WriteLine($"Fed animal {animal.Name} {food}");
        }
    }
}