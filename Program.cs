using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(
    "+5577999999999",
    "Nokia E71",
    "1254112525778896AA4547878B",
    500
);

Iphone iphone = new Iphone(
    "+5577999998888",
    "Iphone XR",
    "1254112525778896AA4548787A",
    2000
);

//Exibindo número do Smartphone NOKIA
Console.WriteLine($"NUMERO: {nokia.Numero}");
//Fazendo ligação número do Smartphone
nokia.Ligar();
//Recebendo ligação número do Smartphone
nokia.ReceberLigacao();
//Instalando aplicativo
nokia.InstalarAplicativo("Whatsapp");


//Exibindo número do Smartphone NOKIA
Console.WriteLine($"NUMERO: {iphone.Numero}");
iphone.InstalarAplicativo("Instagram");
