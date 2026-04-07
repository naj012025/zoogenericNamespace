namespace zoogenerics.Interface;

public interface IAnimalPusher<in T>
{
    void Push(T obj);
}