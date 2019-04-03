using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory {
   public class CarClient {
      private ISedan sedan;
      private ISuv suv;

      public string Sedan { get { return sedan.Name(); } }
      public string Suv { get { return suv.Name(); } }

      public CarClient(ICarFactory factory, Segment segment) {
         sedan = factory.ManufactureSedan(segment);
         suv = factory.ManufactureSuv(segment);
      }
   }
}
