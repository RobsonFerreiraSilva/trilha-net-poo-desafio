// Arquivo: Program.cs
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia G21", imei: "111111111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-----------------------------------\n");

Console.WriteLine("Testando Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15 Pro", imei: "222222222222222", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");