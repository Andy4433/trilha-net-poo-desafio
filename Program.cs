using DesafioPOO.Models;

Iphone iphone = new Iphone("+55 (19)9 9473-8516");
List<string> aplicativos = new List<string> {"flappy bird", "angry bird", "zapzap" };
iphone.InstalarAplicativo(aplicativos);

iphone.mostraApp(aplicativos);
// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("----------------------------------------------------");
Nokia Tijolão = new Nokia("+55 (19)9 9473-8516");
Tijolão.Ligar();
List<string> aplicativo = new List<string> {"Fortinite", "Free Fire" };
Tijolão.InstalarAplicativo(aplicativo);

iphone.mostraApp(aplicativo);