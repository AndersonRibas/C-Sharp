using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod {
   /// <summary>  
   /// The 'Product' Abstract Class  
   /// </summary>  
   public abstract class CreditCard {
      public abstract string CardType { get; }
      public abstract int CreditLimit { get; set; }
      public abstract int AnnualCharge { get; set; }
   }
}
