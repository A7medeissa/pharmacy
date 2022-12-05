using System;
using System.Collections.Generic;
namespace Pharmacy{
   public class Drug1 : Drug
    {
       private static int  Quantity=0;
       private static double Price;
       

        public Drug1(string dateTime, double price)
        {
           SetEpirationDate(dateTime);
           Price=price;

        }

        
        public override string DrugType()
        {
           return "Drug1";
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