using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder {
   /// <summary>
   /// The 'ConcreteBuilder1' class
   /// </summary>
   public class HeroBuilder : IVehicleBuilder {
      Vehicle objVehicle = new Vehicle();
      public void SetModel() {
         objVehicle.Model = "Hero";
      }

      public void SetEngine() {
         objVehicle.Engine = "4 Stroke";
      }

      public void SetTransmission() {
         objVehicle.Transmission = "120 km/hr";
      }

      public void SetBody() {
         objVehicle.Body = "Plastic";
      }

      public void SetAccessories() {
         objVehicle.Accessories.Add("Seat Cover");
         objVehicle.Accessories.Add("Rear Mirror");
      }

      public Vehicle GetVehicle() {
         return objVehicle;
      }
   }

   /// <summary>
   /// The 'ConcreteBuilder2' class
   /// </summary>
   public class HondaBuilder : IVehicleBuilder {
      Vehicle objVehicle = new Vehicle();
      public void SetModel() {
         objVehicle.Model = "Honda";
      }

      public void SetEngine() {
         objVehicle.Engine = "4 Stroke";
      }

      public void SetTransmission() {
         objVehicle.Transmission = "125 Km/hr";
      }

      public void SetBody() {
         objVehicle.Body = "Plastic";
      }

      public void SetAccessories() {
         objVehicle.Accessories.Add("Seat Cover");
         objVehicle.Accessories.Add("Rear Mirror");
         objVehicle.Accessories.Add("Helmet");
      }

      public Vehicle GetVehicle() {
         return objVehicle;
      }
   }
}
