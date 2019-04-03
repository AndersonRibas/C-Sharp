using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory {
   public class HondaFactory : ICarFactory {
      public ISedan ManufactureSedan(Segment segment) {
         switch (segment) {
            case Segment.Compact:
               return new HondaCompactSedan();
            case Segment.Full:
               return new HondaFullSedan();
            default:
               throw new Exception();
         }
      }
      public ISuv ManufactureSuv(Segment segment) {
         switch (segment) {
            case Segment.Compact:
               return new HondaCompactSuv();
            case Segment.Full:
               return new HondaFullSuv();
            default:
               throw new Exception();
         }
      }
   }

   public class ToyotaFactory : ICarFactory {
      public ISedan ManufactureSedan(Segment segment) {
         switch (segment) {
            case Segment.Compact:
               return new ToyotaCompactSedan();
            case Segment.Full:
               return new ToyotaFullSedan();
            default:
               throw new Exception();
         }
      }

      public ISuv ManufactureSuv(Segment segment) {
         switch (segment) {
            case Segment.Compact:
               return new ToyotaCompactSuv();
            case Segment.Full:
               return new ToyotaFullSuv();
            default:
               throw new Exception();
         }
      }
   }
}
