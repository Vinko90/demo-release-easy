using DemoVersioning.Core;

Console.WriteLine("Versions:");

Console.WriteLine($"Assembly Version: {Tool.GetAssemblyVersion()}");
Console.WriteLine($"File Version: {Tool.GetFileVersion()}");
Console.WriteLine($"Product Version: {Tool.GetProductVersion()}");
