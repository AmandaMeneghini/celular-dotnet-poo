using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando IPhone: ");

Iphone iphone = new Iphone("(11)99999-9999","iPhone 11 Plus","5986b%", 64);
iphone.InstalarAplicativo("Candy Crush");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("\n");
Console.WriteLine("Testando Nokia: ");

Nokia nokia = new Nokia ("(21)98555-5555","Nokia G21","875444#", 128);
nokia.InstalarAplicativo("Fortnite Mobile");
nokia.Ligar();
nokia.ReceberLigacao();