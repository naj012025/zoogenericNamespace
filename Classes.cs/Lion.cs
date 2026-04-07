namespace zoogenerics.Classes;

public class Lion(string name, FoodConsumption food, int age, string coat) : Animal(name, food, age)
{
    public string Coat { get; set; } = coat;
}