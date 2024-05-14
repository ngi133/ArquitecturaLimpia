// See https://aka.ms/new-console-template for more information
using _03_Dominio.Entidades;

Console.WriteLine("Hello, World!");

Usuario eduardo = new Usuario(
    Guid.NewGuid(),
    "Eduardo",
    "edu@test.com",
    "123",
    DateTime.Now 
 );

Console.WriteLine("fin");