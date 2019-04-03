using System;
using System.Collections.Generic;
using System.Text;
using TrabalhoDesignPatterns.Enums;

namespace TrabalhoDesignPatterns.Builder
{
    public class Computer
    {
        public string Model { get; set; }
        public RAMType RAM { get; set; }
        public CPU CPU { get; set; }
        public Monitor Monitor { get; set; }

        public Computer()
        {
            CPU = new CPU();
            Monitor = new Monitor();
        }

        public static implicit operator Computer(ComputerCreator v)
        {
            throw new NotImplementedException();
        }
    }
}
