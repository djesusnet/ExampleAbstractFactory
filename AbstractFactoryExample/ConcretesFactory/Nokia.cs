using AbstractFactoryExample.Interfaces;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AbstractFactoryExample.ConcretesFactory
{
    /// <summary>
    /// ConcreteFactory1
    /// </summary>
    public class Nokia : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
