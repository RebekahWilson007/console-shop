using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_shop
{
    internal class Program
    {
        //global variables
        public static string storedUsername = "R";
        public static string username = "";
        public static int balence = 100;
        public static int TopUpAmount = 0;
        public static int select = 0;
        public static string Select = " ";
        public static int Cart = 0;
        public static string itemName = "";
        public static string Cartitems = "";
        public static int item = 0;
        public static bool usernameWhile = true;
        public static int attempts = 0;

        //Inventory Arrays and matching price array's
        //public static string[] Shoes = { "Red heels", "White Fashion sneakers", "Red Jandels", "Red slippers", "Yellow slides" };
        //public static int[] ShoesPrice = {80,100,10,12,25};
        //public static string[] Jewelery = {"Rose Gold heart drop earrings", "Rose gold heart necklace", "Rose gold heart studs", "Rose gold heart bangels", "Rose gold heart broach"};
        //public static int[] JeweleryPrice = {15, 14, 10, 15, 8};
        //public static string[] Accesories = {"Red Sunglasses", "Red Scarf", "Red Bucket Hat", "Red Simbrero", "Yellow Socks");
        //public static int[] Accesories = {20,15,25,20,15};
        public static void ShopFront()
        {
            Console.Clear();
            Console.WriteLine("\t________________________________________");
            Console.WriteLine("\t\t Shopping Categories");
            Console.WriteLine("\t________________________________________\n");
            Console.WriteLine("\t Shop Shoes                          -Press [1]\n");
            Console.WriteLine("\t Shop Jewelery                       -Press [2]\n");
            Console.WriteLine("\t Shop Accesories                     -Press [3]\n");
            Console.WriteLine("\t Add funds to your balence           -Press [4]\n");
            Console.WriteLine("\t Exit                                -Press [5]\n");
            Console.WriteLine("\t Veiw cart and check out             -Press [6]\n");
            Console.WriteLine("\tPlease enter your selection below\n");
            select = 0;
            select = int.Parse(Console.ReadLine());

            while(1==1)
         {
                switch (select)
                {
                    case 1:
                        {
                            ShopShoes();
                            break;
                        }
                    case 2:
                        {
                            ShopJewelery();
                            break;
                        }
                    case 3:
                        {
                            ShopAccesories();
                            break;
                        }
                    case 4:
                        {
                            TopUp();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine($"\n\tHave as great day {username}! Thanks for shoping with Live, Laugh, Love.\n");
                            Console.WriteLine("\t Press any key to exit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            select = 0;
                            while (select == 0)
                            {
                                Console.WriteLine($"\n\n\t Your Cart total is ${Cart} With the following items");
                                Console.WriteLine($"\n\t{Cartitems}.");
                                Console.WriteLine("\n\t To check out          -Press [1]");
                                Console.WriteLine("\n\t To continue shoping   -Press [2].");
                                Console.WriteLine("\n\t To clear cart         -Press [3].\n");
                                Console.WriteLine("\tPlease select from the above options.");
                                select = int.Parse(Console.ReadLine());

                                if (select == 1)
                                {
                                    Checkout();
                                    break;
                                }
                                if (select == 2)
                                {
                                    ShopFront();
                                    break;
                                }
                                if (select == 3)
                                {
                                    Console.Clear();
                                    Cart = 0;
                                    Console.WriteLine("\n\tYour cart is now empty to continue shopping Press any key.");
                                    Console.ReadKey();
                                    ShopFront();
                                    break;

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\tEntry invalid press any key to try again.");
                                    select = 0;
                                    Console.ReadKey();
                                }


                            }//cart while
                            ShopFront();
                                break;
                            
                        }//case 6

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t Entry invalid please try again -Press any key to continue.");
                            select = 0;
                            Console.ReadKey();
                            ShopFront();
                            break;
                        }
                }      
            }





        }
        public static void ShopShoes()
        {
            Console.Clear();
            select = 0;
            while (select == 0)
            {
                Console.WriteLine("\n\t♥♥♥Shoes♥♥♥\n");
                Console.WriteLine("\tRed Steletos           [$80.00]  -Press [1]\n");
                Console.WriteLine("\tWhite fashion Sneakers [$100.00] -Press [2]\n");
                Console.WriteLine("\tRed Jandels            [$10.00]  -Press [3]\n");
                Console.WriteLine("\tRed Slippers           [$12.00]  -Press [4]\n");
                Console.WriteLine("\tYellow Slides          [$20.00]  -Press [5]\n");
                Console.WriteLine("\tReturn to Shop Front             -Press [6]\n");
                Console.WriteLine("\tPlease select from the above options");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        {
                            Console.Clear();
                            select = 0;
                            Console.WriteLine("\n\tRed Steletos\n\t These comfy 4 inch pumps will help you dance the night away\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                //add item and price to the cart
                                item = 80;
                                itemName = "\t:Red Steletos\n";
                                Cart += item;
                                Cartitems += itemName;


                                while (1==1)
                                {

                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} costing ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopShoes();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            if (select == 2)
                            {
                                ShopShoes();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            select = 0;
                            Console.WriteLine("\n\tWhite sneakers\n\t These faux leather sneakers are scratch and dirt resistent, the perfect accompaniyment for any outfit\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 100;
                                itemName = "\t:White Fashion Sneakers\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           -Press [1]\n\t To continue shopping   -Press [2] ");
                                    select = 0;
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopShoes();
                                        break;
                                    }
                                    if(select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }

                                    
                                }
                              
                            }
                            if (select == 2)
                            {
                                ShopShoes();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                

                    case 3:
                        {
                            Console.Clear();
                            select = 0;
                            Console.WriteLine("\n\tRed Jandels\n\t These are the kiwi classics you know and love\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 10;
                                itemName = "\t:Red Jandels\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    select = 0;
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }

                                    if (select == 2)
                                    {
                                        ShopShoes();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopShoes();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        
                         }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRed Slippers\n\t These comfy fluffy ankle booties are perfect for those long winter nights\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 12;
                                itemName = "\t:Red Slippers\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    select = 0;
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out          -Press [1]\n\t To continue shopping     -Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopShoes();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                               
                            }
                            if (select == 2)
                            {
                                ShopShoes();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        
                }

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tYellow Slides\n\t These comfy cushiony slides are like walking on clouds\n\t You can wear your socks at the same time, we won't judge.\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 20;
                                itemName = "\t:Yellow Slides\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    select = 0;
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopShoes();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopShoes();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        
                }
                    case 6:
                            {
                            ShopFront();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t Entry invalid please try again.");
                            select = 0;
                            break;

                        }
                }

            }
        }
        public static void ShopAccesories()
        {
            Console.Clear();
            select = 0;
            while (select == 0)
            {

                Console.WriteLine("\n\t♥♥♥Accesories♥♥♥\n");
                Console.WriteLine("\tRed Sunglasses                [$20.00] -Press [1]\n");
                Console.WriteLine("\tRed scaves                    [$15.00] -Press [2]\n");
                Console.WriteLine("\tRed Bucket hat                [$25.00] -Press [3]\n");
                Console.WriteLine("\tRed simbrero                  [$20.00] -Press [4]\n");
                Console.WriteLine("\tYellow socks                  [$5.00]  -Press [5]\n");
                Console.WriteLine("\tReturn to Shop Front                   -Press [6]\n");
                Console.WriteLine("\tPlease select from the above options");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tPassionate Red Sunglasses\n\t These heart shaped frames will makes your eyes love you\n");
                            Console.WriteLine("\t To purchase                     -press [1]\n");
                            Console.WriteLine("\t To return to Browse Accesories  -press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 20;
                                itemName = "\t:Red Sunglasses\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRuby Red Scarf\n\t Warming wool scarfy to protect you from any winter chills\n");
                            Console.WriteLine("\t To purchase                     -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Accesories  -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 15;
                                item = 80;
                                itemName = "\t:Red Scarf\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = 0;
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                               
                            }
                            if (select == 2)
                            {
                                ShopAccesories();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t Red Bucket hat\n\t Brilliant racing car red hat to sheid your eyes from the sun\n");
                            Console.WriteLine("\t To purchase                 -press [1]");
                            Console.WriteLine("\t To return to Browse Accesories -press [2]");
                            Console.WriteLine("\t To return to Shop Front     -press [3]");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 25;
                                itemName = "\t:Red Bucket hat\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRed Simberro\n\t Vibrant hat with extra wide brim to keep you shelter from the fierce sun.\n");
                            Console.WriteLine("\t To purchase                     -Press [1]");
                            Console.WriteLine("\t To return to Browse Accesories  -Press [2]");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 20;
                                itemName = "\t:Red Simbrerro\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tYellow Socks\n \tComfy cosey Yellow socks that will make your feet happy\n");
                            Console.WriteLine("\t To purchase                     -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Accesories  -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 5;
                                itemName = "\t:Yellow Socks\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                    case 6:
                        {
                            ShopFront();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t Entry invalid please try again.");
                            select = 0;
                            break;

                        }//end default
                }//end switch
            }//end while
        }//end void
        public static void ShopJewelery()
        {
            Console.Clear();
            select = 0;
            while (select == 0)
            {
                Console.WriteLine("\n\t♥♥♥Jewelery♥♥♥\n");
                Console.WriteLine("\tRose gold heart Drop earrings       [$15.00] -Press [1]\n");
                Console.WriteLine("\tRose gold heart Necklace            [$14.00] -Press [2]\n");
                Console.WriteLine("\tRose gold heart Stud earrings       [$10.00] -Press [3]\n");
                Console.WriteLine("\tRose gold heart Bangles             [$15.00] -Press [4]\n");
                Console.WriteLine("\tRose gold heart Broach              [$8.00]  -Press [5]\n");
                Console.WriteLine("\tReturn to Shop Front                         -Press [6]\n");
                Console.WriteLine("\tPlease select from the above options");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Drop Earrings\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                       -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery      -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front           -Press [3]\n");
                            Console.WriteLine("\n\n\tPlease select from the options above.");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 15;
                                itemName = "\t:Rose Gold Drop Earrings\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2] ");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }

                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Necklance\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                       -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery      -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front           -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 14;
                                item = 80;
                                itemName = "\t:Rose Gold Necklace\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2] ");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Studs\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                   -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery  -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front       -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 10;
                                itemName = "\t:Rose Gold Studs\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out            -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping    -Press [2] ");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Bangles\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                     -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery    -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 15;
                                itemName = "\t:Rose Gold Bangles\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out                     -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping Jewelery    -Press [2]");
                                    Console.WriteLine("\n\t To continue shopping shop front  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Broach\n\t Simple oval, with a emerald gem in the centre\n");
                            Console.WriteLine("\t To purchase                        -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery       -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front            -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 8;
                                itemName = "\t:Rose gold Broach\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();
                            }
                            if (select == 3)
                            {
                                ShopFront();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }

                    case 6:
                        {
                            ShopFront();
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t Entry invalid please try again.");
                            select = 0;
                            break;

                        }//end default
                }//end switch
            }//end while
        }//end void

        public static void TopUp()
        {
            Console.Clear();
            Console.WriteLine($"\n\tYour current balence is [${balence}]. Enter your Top up amount.");
            TopUpAmount = int.Parse(Console.ReadLine());

            if (TopUpAmount > 0)
            {
                Console.Clear();
                balence = balence + TopUpAmount;
                Console.WriteLine($"\n\tYour balence has been up dated your new balence is [${balence}].\n\t If you would like to now checkout find your cart on the shop front menu!\n\t Press any key to return to the shop front");
                Console.ReadKey();
                ShopFront();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\n\t${TopUpAmount} is an invalid Top up amount.\n\t Press any key to try again");
                Console.ReadKey();
                TopUp();
            }
        }

        public static void Checkout()
        {
            Console.Clear();
            if (Cart <= balence)
            {
                //display cart balance total and cart items, check balance is sufficent, display purchase approved message and updated balance or insufficient funds method- redirect to top up.
                Console.WriteLine($"\n\t {username} you are purchasing the following \n{Cartitems} \n\t Toal = ${Cart}");
                Console.WriteLine($"\n\t Transaction approved your new balance is ${balence -= Cart}.\n");
                Console.WriteLine($"\t Have as great day {username}! Thanks for shoping with Live, Laugh, Love.\n\t Press any Key to Return to Shop Categories.");
                Console.ReadKey();
                select = 0;
                Cart = 0;
                Cartitems = "";
                ShopFront();
            }
            else
            {
                Console.WriteLine($"\n\t Your balence [${balence}] is insuffiecient for that purchase [${Cart}] please Top up.\n");
                //force top up when insuffiecient funds for purchase
                Console.WriteLine("\tPress any key to open top up menu.");
                Console.ReadKey();
                TopUp();
            }
        }

        public static void LoginLoop()
        {
            usernameWhile = true;
            while (usernameWhile == true)
            {
                Console.WriteLine("\tPlease enter a username.");
                username = Console.ReadLine();
                if ((username.Equals(storedUsername, StringComparison.OrdinalIgnoreCase)))
                // lower case or uppercase r/R will work for the username!
                {
                    Console.WriteLine($"\tWelcome {username}!");
                    Console.WriteLine("\tTo welcome you we have topped up your store credit, enjoy!");
                    Console.WriteLine("\t________________________________________\n");
                    Console.WriteLine($"\t Your current balence is ${balence}.\n");
                    Console.WriteLine("\t________________________________________\n");
                    Console.WriteLine("\tLet's get shopping press any key to start!");
                    Console.ReadKey();
                    ShopFront();
                    usernameWhile = false;
                }
                else
                {
                    Console.WriteLine("\t Username invalid please try again.\n\t ( Press any key to try again)");

                    usernameWhile = true;
                    attempts += 1; //add 1 for atempts counter

                    //check attemps
                    if (attempts <= 3)
                    {
                        //still attempts avaliable continue loop
                        Console.ReadKey();
                        LoginLoop();
                        break;
                    }
                    if (attempts > 3)
                    {
                        //force quit too many attempts
                        Console.Clear();
                        Console.WriteLine("\tYou have used up all you attempts please contact Live, laugh, love @ livelaughlove@gmail.com \n\tto reset your login details.");

                        Console.WriteLine("\tPress any key to exit the application.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }

            }
        }
    



        static void Main(string[] args)
        {
        
                Console.Clear();
                Console.WriteLine("\t♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥");
                Console.WriteLine("\t\tWelcome to Live, Laugh, love.");
                Console.WriteLine("\t♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n");
                attempts = 0;
            Console.WriteLine("\tLive, laugh, love is dedicated to making your shopping experience enjoyable!\n\t We sell only the highest quality shoes, jewelery and accesories!\n");
            Console.WriteLine("\n\tPress any key to login");
                Console.ReadKey();
       
                LoginLoop();
    
    
        }
    }
}
