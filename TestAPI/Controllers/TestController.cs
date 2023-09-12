using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Requests;
using TestAPI.Results;

namespace TestAPI.Controllers;

public class TestController
{
    private readonly IMediator _mediator;

    public TestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("/test1")]
    public Task<TestResult> TestGet1([FromQuery] TestRequest request)
    {
        return _mediator.Send(request);
    }
    [HttpGet("/test2")]
    public Task<Test2Result> TestGet2([FromQuery] Test2Request request)
    {
        return _mediator.Send(request);
    }
}