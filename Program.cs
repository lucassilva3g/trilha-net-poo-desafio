using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone smartphone2 = new(numero: "987654321", modelo: "iphone1", imei: "def5678", memoria: 2048);
Nokia smartphone1 = new(numero: "123456789", modelo: "nokia1", imei: "abc1234", memoria: 2048);

Console.WriteLine("Smartphone Iphone:");
smartphone2.Ligar();
smartphone2.InstalarAplicativo(nomeApp: "Facebook");
smartphone2.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
smartphone1.Ligar();
smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");
smartphone1.ReceberLigacao();
