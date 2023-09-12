using MediatR;
using TestAPI.Results;

namespace TestAPI.Requests;

public record TestRequest : IRequest<TestResult>
{
    public string Title { get; set; }
}