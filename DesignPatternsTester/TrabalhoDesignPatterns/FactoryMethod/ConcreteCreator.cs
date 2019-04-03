using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoDesignPatterns.FactoryMethod
{
    public class AllinOneFactory : CompFactory
    {
        

        public override Computer GetComputer()
        {
            return new AllinOne();
        }
    }

    public class NotebookFactory : CompFactory
    {


        public override Computer GetComputer()
        {
            return new Notebook();
        }
    }
}
