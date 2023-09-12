namespace TestAPI;

public interface IAlgorithm<in TInput, out TResult>
{
    TResult DoWork(TInput input);
}