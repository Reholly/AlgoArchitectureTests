using MediatR;
using TestAPI.Requests;
using TestAPI.Results;

namespace TestAPI.Handlers;

public class Test1Handler : IRequestHandler<TestRequest, TestResult>
{
    public Task<TestResult> Handle(TestRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}