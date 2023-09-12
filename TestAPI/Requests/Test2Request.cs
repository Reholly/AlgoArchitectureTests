using MediatR;
using TestAPI.Results;

namespace TestAPI.Requests;

public class Test2Request : IRequest<Test2Result>
{
    public int TestAge { get; set; }
}