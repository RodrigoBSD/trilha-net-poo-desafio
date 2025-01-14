namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        protected bool Ligado { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
            this.Ligado = false;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            if(Ligado == true)
            {
                Console.WriteLine("O aparelho já está ligado");
            }
            else
            {
                Console.WriteLine("Ligando...");
                Ligado = true;
            }
            
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}