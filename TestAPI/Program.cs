using MediatR;
using TestAPI;
using TestAPI.Algorithms;
using TestAPI.Handlers;
using TestAPI.Requests;
using TestAPI.Results;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IAlgorithm<TestRequest, TestResult>, Test1Algo>();
builder.Services.AddSingleton<IAlgorithm<Test2Request, Test2Result>, Test2Algo>();

builder.Services.AddMediatR(mediatr =>
{
    mediatr.RegisterServicesFromAssemblyContaining<Program>();
});
builder.Services.Decorate(typeof(IRequestHandler<,>), typeof(AlgorithmDecorator<,>));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();