using TestAPI.Requests;
using TestAPI.Results;

namespace TestAPI.Algorithms;

public class Test2Algo : IAlgorithm<Test2Request, Test2Result>
{
    public Test2Result DoWork(Test2Request input)
    {
        //some work
        return new Test2Result { MultipliedAge = input.TestAge * 10 };
    }
}