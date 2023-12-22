namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public override void desligar()
        {
            System.Console.WriteLine("Desligando o iPhone...");
        }

        public override void InstalarAplicativo(List<string> nomesApps)
        {
            System.Console.WriteLine("add app....");
            foreach(var i in nomesApps){
                System.Console.WriteLine($" - {i}");
            }
        }

        public override void mostraApp(List<string> nomesApps)
        {
            System.Console.WriteLine("Segue a lista de aplicativos:");

            for (int i = 0; i < nomesApps.Count; i++)
            {
                System.Console.Write(nomesApps[i]);

                // Adiciona uma vírgula se não for o último elemento
                if (i < nomesApps.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(); // Adiciona uma nova linha após a lista
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}