using MediatR;

namespace TestAPI.Handlers;

public class AlgorithmDecorator<TRequest, TResult> : IRequestHandler<TRequest, TResult> 
    where TRequest : IRequest<TResult>
{
    private readonly IAlgorithm<TRequest, TResult> _algorithm;

    public AlgorithmDecorator(IRequestHandler<TRequest,TResult> handler, IAlgorithm<TRequest, TResult> algorithm)
    {
        _algorithm = algorithm;
    }

    public Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
    {
        //measurements
        var result = _algorithm.DoWork(request);
        //end measurements

        return Task.FromResult(result);
    }
}