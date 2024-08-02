using DesafioPOO.Models;

Console.WriteLine("Smartiphone Nokia:");
Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Nokia 3210", imei : "123456789", memoria : 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "11888888888", modelo: "Iphone 13", imei : "987654321", memoria : 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

