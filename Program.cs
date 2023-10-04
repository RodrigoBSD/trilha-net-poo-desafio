using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("1195789483","Nokia C20","58465134348", 12);

nokia.Ligar();
nokia.InstalarAplicativo("Clash of Clans");
nokia.ReceberLigacao();

Console.WriteLine("");

Iphone iphone = new Iphone("1195254658","Iphone 15","86724958357", 16);

iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();
