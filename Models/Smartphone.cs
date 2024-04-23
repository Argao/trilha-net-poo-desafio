namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set;}
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        protected List<string> AplicativosInstalados  = new List<string>();
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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

        public void ListarAplicativos()
        {
            if (AplicativosInstalados.Count == 0)
            {
                Console.WriteLine("Nenhum aplicativo instalado");
                return;
            }else
            {
                Console.WriteLine("Aplicativos instalados: ");                
                foreach (var app in AplicativosInstalados)
                {
                    Console.WriteLine(app);
                }
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void ExibirSpecs();
    }
}