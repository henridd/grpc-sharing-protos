// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using Protos;

var grpcChannel = GrpcChannel.ForAddress("https://localhost:7161");
var greeter = new Greeter.GreeterClient(grpcChannel);
var request = new HelloRequest() { Name = "World" };
var response = await greeter.SayHelloAsync(request);
Console.WriteLine(response);
Console.ReadLine();