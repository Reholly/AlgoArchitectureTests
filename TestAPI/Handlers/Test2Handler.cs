using MediatR;
using TestAPI.Requests;
using TestAPI.Results;

namespace TestAPI.Handlers;

public class Test2Handler : IRequestHandler<Test2Request, Test2Result>
{
    public Task<Test2Result> Handle(Test2Request request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}