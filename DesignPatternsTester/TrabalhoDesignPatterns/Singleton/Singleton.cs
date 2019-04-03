using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoDesignPatterns.Singleton
{
    public class Factory
    {
        private static Factory factory;
        public string Name { get; set; }

        private Factory() { }

        public static Factory Instance
        {
            get
            {
                if(factory == null)
                {
                    factory = new Factory();
                }
               
                return factory;
            }
        }
    }
}
