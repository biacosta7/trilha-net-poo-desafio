using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo X", imei: "9999999", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo y", imei: "0000000", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Google Meet");