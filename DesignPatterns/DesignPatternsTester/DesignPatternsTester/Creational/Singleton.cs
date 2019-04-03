using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDesignPatterns.Singleton;

namespace DesignPatternsTester.Creational {
   public class Singleton {
      public void Run() {
         Console.WriteLine("Run this example step by step using F11 to see the result.");
            Factory factory = Factory.Instance;
            factory.Name = "Computer Factory";
            Console.WriteLine(">>{0}<<", factory.Name);
         

      }

   }
}
