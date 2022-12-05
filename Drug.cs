using System;
using System.Collections.Generic;
namespace Pharmacy{
   public abstract class Drug{
      
       private DateTime Expiration_date;
       public abstract string DrugType();
       public  void SearchIfExist(int Quantity){
         if (Quantity>0){
            
               Console.WriteLine($"{DrugType()} is existed");
            }
          else{
           Console.WriteLine($"{DrugType()} is not existed!"); }           

        }
       
        

       
       //public  abstract void StoreQuantity(int quantity);
       public void CheckIfStillValid(int Quantity){
            if( Expiration_date> DateTime.Now){
                Console.WriteLine($"{DrugType()} is still valid ");
            }else{
                Quantity--;
               
                 Console.WriteLine($"{DrugType()} is Corrupted ");
                 /// DESTROY  THIS INSTANCE
            }
       }

      
       public DateTime GetEpirationDate(){
         return Expiration_date;
       }
       public void SetEpirationDate(string dateTime){
          Expiration_date=DateTime.Parse(dateTime);
       }
       
    }
}