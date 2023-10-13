namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Digite o nome do App para instalação: ");
            string aplicativo = Console.ReadLine();
            if (string.IsNullOrEmpty(aplicativo))
            {
                Console.WriteLine("Instalação cancelada. O nome do aplicativo é nulo.");
            }
            else
            {
                Console.WriteLine($"O app {aplicativo} foi instalado com sucesso no seu Iphone.");
            }
        }
    }
}
