using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoDesignPatterns.Builder
{
    public class ComputerCreator
    {
        private readonly IComputerBuilder objBuilder;

        public ComputerCreator (IComputerBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateComputer()
        {
            objBuilder.SetModel();
            objBuilder.SetCPU();
            objBuilder.SetMonitor();
            objBuilder.SetRAM();
        }

        public Computer GetComputer()
        {
            return objBuilder.GetComputer();
        }
    }
}
