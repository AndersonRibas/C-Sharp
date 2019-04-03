using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDesignPatterns.FactoryMethod;

namespace DesignPatternsTester.Creational {
   public class FactoryMethod {
      public void Run() {
     
         CompFactory factory = null;
         Console.Write("Enter the computer type you would like to visit: ");
         string comp = Console.ReadLine();

         switch (comp.ToLower()) {
            case "allinone":
               factory = new AllinOneFactory();
               break;
            case "notebook":
               factory = new NotebookFactory();
               break;
           default:
               break;
         }

         Computer computer = factory.GetComputer();
            Console.WriteLine(  ">>>Factory {0}<<<", computer.GetNome());
      }
   }
}
