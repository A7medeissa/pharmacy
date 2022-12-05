using System;
using System.Collections.Generic;
namespace Pharmacy{
    class Program{
        static void Main(string[] argc){
            var drug1 =new Drug1("12/30/2024 11:59:00",15.5);
            var drug2 =new Drug2("12/30/2024 11:59:00",21.0);
            var drug3 =new Drug3("12/30/2024 11:59:00",54.5);
            //mydrug.AddDrugType();
            while(true){
                Console.WriteLine("enter 1 for store 2 for checking 3 for know price 4 know the quantity 5 for search 6 for exit");
                var input =Console.ReadLine();
                if(int.Parse(input)==1){
                    Console.WriteLine("enter 1 for store Drug1 || 2 for store Drug2 || 3 for store Drug3");
                     input =Console.ReadLine();

                     switch(int.Parse(input)){
                        case  var d when d==1:
                            Console.WriteLine("enter the quantitysize");
                            input =Console.ReadLine();  
                                
                            drug1.StoreQuantity(int.Parse(input));
                            break;
                        case  var d when d==2:
                            Console.WriteLine("enter the quantitysize");
                            input =Console.ReadLine();  
                                
                            drug2.StoreQuantity(int.Parse(input));
                            break;
                        case  var d when d==3:
                            Console.WriteLine("enter the quantitysize");
                            input =Console.ReadLine();  
                                
                            drug3.StoreQuantity(int.Parse(input));
                            break;
                     }
                }else if(int.Parse(input)==2){
                    Console.WriteLine("enter 1 for check Drug1 instance || 2 for check Drug2 instance || 3 for check Drug3 instance");
                     input =Console.ReadLine();
                     switch(int.Parse(input)){
                        case var d when d==1:
                           drug1.CheckIfStillValid(drug1.GetQuantity());
                           break;
                        case var d when d==2:
                           drug2.CheckIfStillValid(drug2.GetQuantity());
                           break;
                        case var d when d==3:
                           drug3.CheckIfStillValid(drug3.GetQuantity());
                           break;
                     }
                }else if(int.Parse(input)==3){
                    Console.WriteLine("enter 1 for getprice Drug1 || 2 for getprice Drug2 || 3 for getprice Drug3");
                     input =Console.ReadLine();
                     switch(int.Parse(input)){
                        case var d when d==1:
                            double price= drug1.GetPrice();
                            Console.WriteLine($" price is: {price }");

                           break;
                        case var d when d==2:
                            price= drug2.GetPrice();
                            Console.WriteLine($" price is: {price }");
                           break;
                        case var d when d==3:
                            price= drug3.GetPrice();
                            Console.WriteLine($" price is: {price }");
                           break;
                     }
                     
                }else if(int.Parse(input)==4){
                    Console.WriteLine("enter 1 for get quantity Drug1 || 2 for getquantity Drug2 || 3 for getquantity Drug3");
                     input =Console.ReadLine();
                     switch(int.Parse(input)){
                        case var d when d==1:
                           int number1= drug1.GetQuantity();
                           Console.WriteLine($" Quantitysize {number1 }");

                           break;
                        case var d when d==2:
                            int number2= drug2.GetQuantity();
                           Console.WriteLine($" Quantitysize {number2 }");
                           break;
                        case var d when d==3:
                           int number3= drug3.GetQuantity();
                           Console.WriteLine($" Quantitysize {number3 }");
                           break;
                     }

                }else if(int.Parse(input)==5){
                    Console.WriteLine("enter 1 for search Drug1 instance || 2 for search Drug2 instance || 3 for search Drug3 instance");
                    input =Console.ReadLine();
                    switch(int.Parse(input)){
                        case var d when d==1:
                            drug1.SearchIfExist(drug1.GetQuantity());
                            break;
                            case var d when d==2:
                            drug2.SearchIfExist(drug2.GetQuantity());
                            break;
                            case var d when d==3:
                            drug3.SearchIfExist(drug3.GetQuantity());
                            break;}

                }else{
                    break;
                }

            
            }
             var drug4=new Drug1("12/30/2024 11:59:00",15.5);
             drug4.StoreQuantity(30);
             var drug5=new Drug1("12/30/2024 11:59:00",15.5);
             drug5.StoreQuantity(20);
             int number =drug4.GetQuantity();
             Console.WriteLine($" number of instances {number }");
        
        
        }
        
    }
}