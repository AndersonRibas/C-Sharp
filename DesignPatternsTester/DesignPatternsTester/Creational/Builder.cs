using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDesignPatterns.Builder;
using TrabalhoDesignPatterns.Enums;

namespace DesignPatternsTester.Creational
{
    public class Builder
    {
        public void ShowInfo(Computer comp)
        {
            Console.WriteLine("Model: {0}", comp.Model);
            Console.WriteLine("RAM: {0}", comp.RAM);
            Console.WriteLine("CPU Clock: {0} ", comp.CPU.Clock);
            Console.WriteLine("Processador {0}", comp.CPU.Brancd);
            Console.WriteLine("Monitor: {0}", comp.Monitor.Inches);
            Console.WriteLine("WideScreen: {0}", comp.Monitor.WideScreen);

        }

        public void Run()
        {
            ComputerCreator computerCreator = null;
            Console.WriteLine("Dell or Positivo?");
            string op = Console.ReadLine();
            switch (op.ToLower())
            {
                case "dell":
                    computerCreator = new ComputerCreator(new DellBuilder());
                    break;
                case "notebook":
                    computerCreator = new ComputerCreator(new PositivoBuilder());
                    break;
                default:
                    break;
            }


            Computer computer = computerCreator.GetComputer();
            ShowInfo(computer);
            Console.WriteLine("");

        }
    }
}
