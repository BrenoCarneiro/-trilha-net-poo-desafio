using DesafioPOO.Models;


Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 3310", imei: "11111111", memoria: 64);
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Modelo X", imei: "22222222", memoria: 128);

nokia.Numero = "012345678";
Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\nSmartphone Iphone:");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();