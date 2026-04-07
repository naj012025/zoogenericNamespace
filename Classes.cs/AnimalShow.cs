namespace zoogenerics.Classes;

public class AnimalShow<T>(List<T> performers) : IAnimalShow<T>
{
    private List<T> _performers = performers;

    public T GetNextPerformer()
    {
        var performer = _performers[0];

        _performers.RemoveAt(0);

        _performers.Add(performer);

        return performer;
    }

    public int PerformerCount => _performers.Count;
}