using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample
{
    /// <summary>
    /// ProdutoA1
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
