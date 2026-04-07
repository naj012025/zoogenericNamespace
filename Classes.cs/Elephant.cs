namespace zoogenerics.Classes;

public class Elephant(string name, FoodConsumption food, int age, string coat) : Animal(name, food, age)
{
    public string Coat { get; set; } = coat;
}