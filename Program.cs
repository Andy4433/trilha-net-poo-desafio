using DesafioPOO.Models;

Iphone iphone = new Iphone("9999999");
List<string> aplicativos = new List<string> {"flappy bird", "angry bird", "zapzap" };
iphone.InstalarAplicativo(aplicativos);

iphone.mostraApp(aplicativos);
// TODO: Realizar os testes com as classes Nokia e Iphone