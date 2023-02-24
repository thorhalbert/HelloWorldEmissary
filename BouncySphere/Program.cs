using BouncySphere;
using EntityABI;
using System.Runtime.InteropServices;

Console.WriteLine($"Hello, world at {DateTime.Now.ToLongTimeString()} on {RuntimeInformation.OSArchitecture}!");

//var entity = new Entity();
//var message = entity.EnterStartup();

//Console.WriteLine($"Message from ABI: {message.Name}");


var wapc = new Wapc();
//wapc.RegisterFunction("hello", hello);

Wapc.testCall();