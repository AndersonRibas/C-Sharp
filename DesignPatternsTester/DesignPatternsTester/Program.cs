using DesignPatternsTester.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTester {
   class Program {
      static void Main(string[] args) {

         CreationalSingleton();
         CreationaltFactoryMethod();
         CreationalBuilder();
         
         Console.ReadKey();
      }


      private static void CreationaltFactoryMethod() {
         FactoryMethod af = new FactoryMethod();
         af.Run();
      }

        private static void CreationalBuilder()
        {
            Builder b = new Builder();
            b.Run();
        }

      private static void CreationalSingleton() {
         Singleton s = new Singleton();
         s.Run();
      }

   }
}
