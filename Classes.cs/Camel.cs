namespace zoogenerics.Classes;

public class Camel(string name, FoodConsumption food, int age, string coat) : Animal(name, food, age)
{
    public string Coat { get; set; } = coat;
}