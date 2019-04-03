using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype {
   public abstract class Employee {
      public abstract Employee Clone();

      public string Name { get; set; }
      public string Role { get; set; }
   }
}
