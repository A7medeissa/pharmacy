using System;
using System.Collections.Generic;
namespace Pharmacy{
   public class Drug2 : Drug
    {
       private static int  Quantity=0;
       private static double Price;
       

        public Drug2(string dateTime, double price)
        {
           //Quantity=0;
           SetEpirationDate(dateTime);
           Price=price;

        }

        
        public override string DrugType()
        {
           return "Drug2";
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