
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria) 
        { 
            Numero= numero;
            Modelo= modelo;
            IMEI= imei;
            Memoria= memoria;
        }
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}
