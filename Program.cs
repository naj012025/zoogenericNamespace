using zoogenerics.Interface;
using zoogenerics.Classes;

static void Main(string[] args)

{

    // Opprette dyreinnhegninger

    var bearPen = new AnimalPen<Bear>(10);

    var camelPen = new AnimalPen<Camel>(10);

    var lionPen = new AnimalPen<Lion>(5);

    var elephantPen = new AnimalPen<Elephant>(3);

    var penguinPen = new AnimalPen<Penguin>(10);



    // Legge til dyr

    bearPen.Push(new Bear("Oluf", FoodConsumption.Carnivore, 12, "Brown"));

    bearPen.Push(new Bear("Randi", FoodConsumption.Carnivore, 10, "Brown"));



    camelPen.Push(new Camel("Kari", FoodConsumption.Herbivore, 8, 2));

    camelPen.Push(new Camel("Oscar", FoodConsumption.Herbivore, 10, 2));



    // ... [Legge til flere dyr] ...



    // Mate dyrene - fungerer takket være kovarians

    ZooFeeder.Feed(bearPen);

    ZooFeeder.Feed(camelPen);

    ZooFeeder.Feed(lionPen);



    // Opprette dyreshow

    var lionShow = new AnimalShow<Lion>([

        new Lion("Leo", FoodConsumption.Carnivore, 8, "Black"),

        new Lion("Leona", FoodConsumption.Carnivore, 7, "Spotted")

    ]);



    // Kjøre show - fungerer takket være kovarians

    ZooManager.RunShow(lionShow);



    // Organisere utstilling - viser kontravarians

    List<Lion> allLions = [

        new Lion("King", FoodConsumption.Carnivore, 10, "Golden"),

        new Lion("Queen", FoodConsumption.Carnivore, 8, "Light Brown")

    ];



    var animalSorter = new AnimalSorter<Animal>();

    ZooManager.OrganizeExhibit(allLions, animalSorter);



    // Generisk beholder for alle dyr

    var generalPen = new AnimalPen<Animal>(20);



    // Demonstrerer både kovarians og kontravarians

    ZooManager.FeedAndTrain(lionPen, generalPen);

    ZooManager.FeedAndTrain(elephantPen, generalPen);

}
