using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory {
   //in the real word, one file for each interface
   public enum Segment { Compact, Full}

   public interface ISedan {
      string Name();
   }

   public interface ISuv {
      string Name();
   }

   public interface ICarFactory {
      ISedan ManufactureSedan(Segment segment);
      ISuv ManufactureSuv(Segment segment);
   }

}
