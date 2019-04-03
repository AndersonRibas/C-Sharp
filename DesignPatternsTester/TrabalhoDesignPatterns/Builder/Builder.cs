using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoDesignPatterns.Builder
{
     public interface IComputerBuilder
    {
        void SetModel();
        void SetRAM();
        void SetCPU();
        void SetMonitor();

        Computer GetComputer();
    }
}
