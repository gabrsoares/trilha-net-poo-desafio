using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456", modelo:"modelo 1", imei:"1111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("456789", "modelo 2", "222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Ifood");