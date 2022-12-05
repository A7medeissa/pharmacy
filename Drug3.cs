using System;
using System.Collections.Generic;
namespace Pharmacy{
   public class Drug3 : Drug
    {
       private static int  Quantity=0;
       private static double Price=0.0;
       

        public Drug3(string dateTime, double price)
        {
          // Quantity=0;
           SetEpirationDate(dateTime);
           Price=price;

        }

        
        public override string DrugType()
        {
           return "Drug3";
        }


        public  void StoreQuantity(int quantity)
        {
            Quantity+=quantity;
        }
        public  int GetQuantity(){
         return Quantity;
        }
        public double GetPrice(){
        return  Price;
       }
       public void SetPrice(double price){
        Price=price;
       }
    }
}