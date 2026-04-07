namespace zoogenerics.Classes;

using zoogenerics.Interface;

public class AnimalPen<T> : IAnimalPopper<T>, IAnimalPusher<T>
{
    private int _position;

    private T[] _pen;

    public AnimalPen(int animalCount)
    {
        _pen = new T[animalCount];
    }

    public void Push(T animal) => _pen[_position++] = animal;

    public T Pop() => _pen[Math.Max(0, --_position)];

    public int Count { get => _position + 1; }

    public T this[int index] => _pen[index];


}