using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod {
   /// <summary>  
   /// The 'Creator' Abstract Class  
   /// </summary>  
   public abstract class CardFactory {
      public abstract CreditCard GetCreditCard();
   }
}
