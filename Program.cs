using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(21) 97159-3516", modelo: "Nokia 5530 MX", imei: "861536-03-019600-1", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero:"(11) 95205-4987", modelo: "iPhone 14 Pro MAX", imei: "749536-05-268620-4", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");