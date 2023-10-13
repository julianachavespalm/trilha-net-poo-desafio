namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero;       
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
              
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Imei
        {
            get { return _imei; }
            set { _imei = value; }
        }

        public int Memoria
        {
            get { return _memoria; }
            set { _memoria = value; }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
