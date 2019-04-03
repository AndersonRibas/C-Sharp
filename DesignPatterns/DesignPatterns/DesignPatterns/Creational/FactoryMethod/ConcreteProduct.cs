using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod {
   /// <summary>  
   /// A 'ConcreteProduct' class  
   /// </summary> 
   public class MoneyBackCreditCard : CreditCard {
      private readonly string _cardType;
      private int _creditLimit;
      private int _annualCharge;

      public MoneyBackCreditCard(int creditLimit, int annualCharge) {
         _cardType = "MoneyBack";
         _creditLimit = creditLimit;
         _annualCharge = annualCharge;
      }

      public override string CardType {
         get { return _cardType; }
      }

      public override int CreditLimit {
         get { return _creditLimit; }
         set { _creditLimit = value; }
      }

      public override int AnnualCharge {
         get { return _annualCharge; }
         set { _annualCharge = value; }
      }
   }

   /// <summary>  
   /// A 'ConcreteProduct' class  
   /// </summary>  
   public class PlatinumCreditCard : CreditCard {
      private readonly string _cardType;
      private int _creditLimit;
      private int _annualCharge;

      public PlatinumCreditCard(int creditLimit, int annualCharge) {
         _cardType = "Platinum";
         _creditLimit = creditLimit;
         _annualCharge = annualCharge;
      }

      public override string CardType {
         get { return _cardType; }
      }

      public override int CreditLimit {
         get { return _creditLimit; }
         set { _creditLimit = value; }
      }

      public override int AnnualCharge {
         get { return _annualCharge; }
         set { _annualCharge = value; }
      }
   }

   /// <summary>  
   /// A 'ConcreteProduct' class  
   /// </summary>  
   public class TitaniumCreditCard : CreditCard {
      private readonly string _cardType;
      private int _creditLimit;
      private int _annualCharge;

      public TitaniumCreditCard(int creditLimit, int annualCharge) {
         _cardType = "Titanium";
         _creditLimit = creditLimit;
         _annualCharge = annualCharge;
      }

      public override string CardType {
         get { return _cardType; }
      }

      public override int CreditLimit {
         get { return _creditLimit; }
         set { _creditLimit = value; }
      }

      public override int AnnualCharge {
         get { return _annualCharge; }
         set { _annualCharge = value; }
      }
   }
}
