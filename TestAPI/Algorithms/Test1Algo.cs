using TestAPI.Requests;
using TestAPI.Results;

namespace TestAPI.Algorithms;

public class Test1Algo : IAlgorithm<TestRequest, TestResult>
{
    public TestResult DoWork(TestRequest input)
    {
        //Some work
        return new TestResult { Answer = "HAHA NEW STTRING" };
    }
}