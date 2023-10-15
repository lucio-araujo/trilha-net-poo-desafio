using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Início dos testes para o Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "+55 (99) 9999-9999", modelo: "N9", imei: "0000-0000-01", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Brawl Stars");

Console.WriteLine("\n");

Console.WriteLine("Início dos testes para o Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "+55 (99) 9999-9999", modelo: "I9", imei: "0000-0000-01", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Salvar Bateria");

Console.ReadLine();
