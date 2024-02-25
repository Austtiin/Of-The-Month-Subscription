/*
 * -----------------------------------------------------------------------
#
##
## Purpose of code:
For purposes of this program:

The user should be able to enter in as many customer orders as they want – please note: keep it simple and assume that they enter in this information one customer at a time. This should be done using a loop that continues until the users states they do not want to enter any more customer orders (use a sentinel value).
For the subscription type and type of shipping they want – the user should be able to enter in more than one. For example: they should be allowed to pick Ice Cream – using regular shipping and then, if they want, pick Peanut Butters – using overnight. This should be done using a loop that continues until the users states they are done (use a sentinel value).
The subscription type and shipping should be stored using arrays. Failure to use arrays will lower your grade.
The total amount due is a calculation for example: an individual who wants bacon for 4 months using a regular shipping method: ($15 * 4) + ($5 * 4) = $80.00. This would earn them a discount of 5 percent: $80 * .95 = $76.00 (Or 80 * .05 = $4 then $80-$4 = $76)
The taxes should be calculated after the discount.
##  

-------------------------------------------------------------Your program must have the following:

You have been hired by an “of the month club” company to create their customer information program. 
This company will provide Ice Cream, Bacon or Fancy Peanut Butters
to a client for a certain number of months as desired.



The customer information program holds the following data:

First Name
Last Name
Subscription Type:
Ice Cream - $12 per month
Bacon - $15 per month
Peanut butters - $17
# of Months the service is Desired
What type of shipping they want to use:
Regular - $5.00 – per month
Expedited - $10.00 – per month
Overnight - $30.00 – per month
Taxes are at 4%
Total Amount Due
If the customer orders over $50 there is a 5% discount
If the customer orders over $100 there is a 7% discount
If the customer orders over $150 there is a 10% discount


Write an application named Subscribers that prompts the user for the subscriber’s name, service type, # of Months and Total Amount Due.
## 
##
## ---------------------------
*/



using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


//define the class named Subscribers
class Subscribers
{
    
    static void Main()
    {
        //Inital
        Console.Clear();
        Console.WriteLine("*** Menu ***");
        
        while (true)
        {
            string[] items = { "Ice Cream", "Bacon", "Peanut Butters" };
            int[] PriceItems = { 12, 15, 17 };
            int[] Months = { 0, 0, 0 };
            int[] TypeServic = new int[3];
            string NameF, NameL;
            


            Console.Write("\nEnter First name : ");
            NameF = Console.ReadLine();
            Console.Write("Enter Last name : ");
            NameL = Console.ReadLine();
            Console.WriteLine("\nSubscription Type:\n1. Ice Cream - $12 per month\n2. Bacon - $15 per month\n3. Peanut butters - $17 per month");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nNumber of months for " + items[i] + " : ");
                Months[i] = Convert.ToInt32(Console.ReadLine());
                if (Months[i] > 0)
                {
                    Console.WriteLine("\nService Type :\n1.Regular - $5.00 – per month\n2. Expedited - $10.00 – per month\n3. Overnight - $30.00 – per month");
                    TypeServic[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nOther Items?, (Y OR N");
                string choice = Console.ReadLine();
          
                if (choice == "Y")
                {
                    continue;
                }
                else
                    break;
            }

            Console.WriteLine("\nName : " + NameF + " " + NameL);

            double TotalAMMT = 0.0;
            for (int i = 0; i < 3; i++)
            {
                if (Months[i] > 0)
                {
                    //Subscription type
                    Console.WriteLine("\nSubscription for : " + items[i]);
                    //compute the CostPerMonth
                    double CostPerMonth = (Months[i] * PriceItems[i]);
                    if (TypeServic[i] == 1)
                    {
                        CostPerMonth += Months[i] * 5;
                    }
                    else if (TypeServic[i] == 2)
                    {
                        CostPerMonth += Months[i] * 10;
                    }
                    else if (TypeServic[i] == 3)
                    {
                        CostPerMonth += Months[i] * 30;
                    }
                    Console.WriteLine("Cost for month for this Subscription for service type chosen = $" + CostPerMonth);
                    TotalAMMT += CostPerMonth;
                }
            }
            




            //discount
            double AmmtAftDiscount = 0.0;
            if (TotalAMMT >= 150)
            {
                AmmtAftDiscount = TotalAMMT - (0.1 * TotalAMMT);
            }
            else if (TotalAMMT < 150 && TotalAMMT >= 100)
            {
                AmmtAftDiscount = TotalAMMT - (0.07 * TotalAMMT);
            }
            else if (TotalAMMT < 100 && TotalAMMT >= 50)
            {
                AmmtAftDiscount = TotalAMMT - (0.05 * TotalAMMT);
            }
     
            Console.WriteLine("Amount after discount = $" + AmmtAftDiscount);

            double amountAfterTax = AmmtAftDiscount + (0.04 * AmmtAftDiscount);
            Console.WriteLine("Final amount after tax = $" + amountAfterTax);

            //ask the user if he wishes to enter details for another customer
            Console.WriteLine("\nAnother person?, (Y Or N)");
            string nextChoice = Console.ReadLine();
            if (nextChoice == "Y")
            {
                continue;
            }  
            else
            {
            }

        }
    }
}





/********* PAST THIS POINT IS UNFINISHED EXTRA: TRIED TURNING EVERYTHING TO CLASS's AND OBJECTS TO LEARN MORE BUT FAILED TO DO SO IN TIME POSTED *************
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * namespace MonthlySubcription
{ 
    class CustomerInfo
    { 
        public int? NumInvoice;
        
        public string? NameF;
        public string? NameL;
        public int? TaxRate = 4;
        public int? ShipSpeed;
        public int? Months;
        public string[] prodlist;
    }

    class Products
    { 
        public string? NameProduct;
        public int PriceProduct;
    }

    class Shipping
    {
       public int? Regular = 5;
        public int? Expedited = 10;
        public int? Overnight = 30;
    }

    
    class OfTheMonth
    { 
        static void Main()
        { 

            
            int i = 0; bool pass = false; string inp = "";
            CustomerInfo[] customerInfo = new CustomerInfo[100];
            Products[] Product = new Products[100];
            Shipping[] Shipping = new Shipping[100];
            Product[1] = new Products(); Product[2] = new Products(); Product[3] = new Products();
            Product[1].NameProduct = "Ice Cream"; Product[1].PriceProduct = 12;
            Product[2].NameProduct = "Bacon"; Product[2].PriceProduct = 15;
            Product[3].NameProduct = "Peanut Butter"; Product[3].PriceProduct = 17;
            

            /////
            while(inp != "exit")
            { 
                Console.Clear();
                Console.WriteLine("\n\n*** Menu ***");
                Console.WriteLine("1. New Subcription");
                Console.WriteLine("2. Change Customer Info");
                Console.WriteLine("3. View Monthly Income");
                Console.WriteLine("4. Exit");
                Console.WriteLine("***  "); 
                inp = Console.ReadLine(); 
                
                switch(inp)
                { 
                    case "1":
                        i++;
                        customerInfo[i] = new CustomerInfo();

                        Console.Clear();
                        Console.WriteLine("** New Customer **");
                        Console.WriteLine("First Name: ");
                        customerInfo[i].NameF = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        customerInfo[i].NameL = Console.ReadLine();
                        Console.WriteLine("");
                        customerInfo[i].NumInvoice = i;
                            
                        Console.Clear();
                         Console.WriteLine("*** Products Requested ***");
                         Console.WriteLine("\n1. " + Product[1].NameProduct + " - $" + Product[1].PriceProduct + "/mo");
                         Console.WriteLine("2. " + Product[2].NameProduct + " - $" + Product[2].PriceProduct + "/mo");
                         Console.WriteLine("3. " + Product[3].NameProduct + " - $" + Product[3].PriceProduct + "/mo");
                         Console.WriteLine("4. (Continue)\n\n");
                         inp = Console.ReadLine();
                        


                        while(inp != "exit")
                        { 
                         
                            switch(inp)
                            {
                                case "1":
                                    
                                    break;

                                case "2":
                                    
                                    break;

                                case "3":
                                    
                                    break;

                                case "4":
                                    inp = "exit;";
                                    break;
                                default:
                                    Console.WriteLine("Please Enter 1-4");
                                    inp = Console.ReadLine();
                                break;
                            }
                        }
                        break;
                        


                    case "2":
                       //change c info
                    break;
                    case "3":
                       //view monthly income
                    break;
                    case "4":
                        //exit
                        inp = "exit";
                    break;
                    default :
                            Console.WriteLine("Please Enter 1-4");
                            inp = Console.ReadLine();
                    break;
                }
            }
        }
    }
}

/*
 *  Console.Clear();
                            Console.WriteLine("*** Products Requested ***");
                            Console.WriteLine("\n1. " + Product[1].NameProduct + " - $" + Product[1].PriceProduct + "/mo");
                            Console.WriteLine("2. " + Product[2].NameProduct + " - $" + Product[2].PriceProduct + "/mo");
                            Console.WriteLine("3. " + Product[3].NameProduct + " - $" + Product[3].PriceProduct + "/mo");
                            Console.WriteLine("4. (Continue)\n\n");
                            inp = Console.ReadLine();

                            switch(inp)
                            { 
                                case "1":
                                    //add Ice Cream
                                    break;

                                case "2":
                                    //add Bacon
                                    break;

                                case "3":
                                    //add peanut butter
                                    break;

                                case "4":
                                    inp = "exit";
                                        break;
                                default:
                                    Console.WriteLine("Please Enter 1-4");
                                    inp = Console.ReadLine();
                                        break;
                            }


                        }








                            Console.WriteLine("\n\n*** Shipping Method ***");
                            Console.WriteLine("1. Regular - $5");
                            Console.WriteLine("2. Expedited - $10");
                            Console.WriteLine("3. Overnight - $30");
                            inp = Console.ReadLine();
                            
                        
                        if(pass == false)
                        { 
                            
                            while(pass == false)
                            {
                                switch(inp)
                                { 
                                    case "1":
                                        pass = true;
                                        customerInfo[i].ShipSpeed = 1;
                                            break;

                                    case "2":
                                        pass = true;
                                        customerInfo[i].ShipSpeed = 2;
                                            break;
                                    case "3":
                                        pass = true;
                                        customerInfo[i].ShipSpeed = 3;
                                            break;
                                    default:
                                        Console.WriteLine("Please Enter 1-3");
                                            inp = Console.ReadLine();
                                                break;
                                }
                            }
                        }
                        pass = false;


                        Console.WriteLine("For How many months? ");
                        customerInfo[i].Months = Convert.ToInt32(Console.ReadLine());
                        Console.ReadLine();


                        */
