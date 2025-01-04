using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo:"Tijolao", imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12345", modelo:"15 pro", imei:"11111111", memoria: 64);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
Console.WriteLine("\n");


