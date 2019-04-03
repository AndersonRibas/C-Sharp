using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype {
   public class Typist : Employee {
      public int WordsPerMinute { get; set; }

      public override Employee Clone() {
         return (Employee)MemberwiseClone();
      }

      public override string ToString() {
         return string.Format("{0} - {1} - {2} wpm", Name, Role, WordsPerMinute);
      }
   }


   public class Developer : Employee {
      public string PreferredLanguage { get; set; }

      public override Employee Clone() {
         return (Employee)MemberwiseClone();
      }

      public override string ToString() {
         return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
      }
   }
}
