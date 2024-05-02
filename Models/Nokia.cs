namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
       public Nokia(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}