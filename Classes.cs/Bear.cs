namespace zoogenerics.Classes;

public class Bear(string name, FoodConsumption food, int age, string coat) : Animal(name, food, age)
{
    public string Coat { get; set; } = coat;
}