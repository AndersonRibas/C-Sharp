using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoDesignPatterns.FactoryMethod
{
    public class AllinOne : Computer
    {
        public override string Nome { get; }

        
        public AllinOne()
        {
            Nome = "AllinOne";
        }

        public override string GetNome()
        {
            return Nome;
        }
    }

    public class Notebook : Computer
    {
        public override string Nome { get; }

        public Notebook()
        {
            Nome = "Notebook";
        }

        public override string GetNome()
        {
            return Nome;
        }
    }
}
