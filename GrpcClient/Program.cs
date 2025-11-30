using Grpc.Net.Client;
using GrpcServer;
using System;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Name = "World!" };
            var channel = GrpcChannel.ForAddress("http://localhost:5070");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            // Just to stop the program from closing.
            Console.ReadLine(); 
        }
    }
}