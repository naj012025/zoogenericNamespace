namespace zoogenerics.Interface;

public interface IAnimalPopper<out T>
{
    T Pop();
}