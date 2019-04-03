using System;
using System.Collections.Generic;
using System.Text;
using TrabalhoDesignPatterns.Enums;

namespace TrabalhoDesignPatterns.Builder
{
    public class PositivoBuilder : IComputerBuilder { 
        Computer objComp = new Computer();
    
        public Computer GetComputer()
        {
            return objComp;
        }

        public void SetCPU()
        {
            objComp.CPU.Brancd = BrandName.Intel;
            objComp.CPU.Clock = 450;
        }

        public void SetModel()
        {
            objComp.Model = "POSITIVO STILO DS3568";
        }

        public void SetMonitor()
        {
            objComp.Monitor.Inches = 19;
            objComp.Monitor.WideScreen = true;
        }

        public void SetRAM()
        {
            objComp.RAM = RAMType._4GB;
        }
    }

    public class DellBuilder : IComputerBuilder
    {
        Computer objComp = new Computer();

        public Computer GetComputer()
        {
            return objComp;
        }

        public void SetCPU()
        {
            objComp.CPU.Brancd = BrandName.Intel;
            objComp.CPU.Clock = 1500;
        }

        public void SetModel()
        {
            objComp.Model = "Inspiron 15 5000";
        }

        public void SetMonitor()
        {
            objComp.Monitor.Inches = 15;
            objComp.Monitor.WideScreen = true;
        }

        public void SetRAM()
        {
            objComp.RAM = RAMType._16GB;
        }
    }
}
