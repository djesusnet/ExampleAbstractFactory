using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample
{
    /// <summary>
    /// ProdutoB1
    /// </summary>
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
