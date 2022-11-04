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
            Console.WriteLine("\t Shop Shoes                           -Press [1]\n");
            Console.WriteLine("\t Shop Jewelery                        -Press [2]\n");
            Console.WriteLine("\t Shop Accesories                      -Press [3]\n");
            Console.WriteLine("\t Veiw and top up your balance         -Press [4]\n");
            Console.WriteLine("\t Exit                                 -Press [5]\n");
            Console.WriteLine("\t Veiw cart and check out              -Press [6]\n");
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
            {//display Shoe menu with prices and select numbers
                Console.WriteLine("\n\t♥♥♥Shoes♥♥♥\n");
                Console.WriteLine("\tRed Steletos           [$80.00]  -Press [1]\n");
                Console.WriteLine("\tWhite fashion Sneakers [$100.00] -Press [2]\n");
                Console.WriteLine("\tRed Jandals            [$10.00]  -Press [3]\n");
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
                            select = 0;//red steleto's desciption and menu page
                            Console.WriteLine("\n\tRed Steletos\n\t These comfy 4 inch pumps will help you dance the night away.\n\t Price: $100\n");
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
                                    {//incorrect entry
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            if (select == 2)
                            {
                                ShopShoes();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//incorrect entry
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
                            select = 0;//white sneakers desciption and menu page
                            Console.WriteLine("\n\tWhite sneakers\n\t These faux leather sneakers are scratch and dirt resistent, the perfect accompaniyment for any outfit\n\t Price: $100\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 100;//add item to cart and calculate cart total
                                itemName = "\t:White Fashion Sneakers\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();//display message item has been added to cart
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           -Press [1]\n\t To continue shopping   -Press [2] ");
                                    select = 0;
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//go to check out
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopShoes();//go to shopshoes menu to continue shopping
                                        break;
                                    }
                                    if(select == 3)
                                    {
                                        ShopFront();//go to shop shoes menu to continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid entry message
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }

                                    
                                }
                              
                            }
                            if (select == 2)
                            {
                                ShopShoes();//go to shop shoes
                            }
                            if (select == 3)
                            {
                                ShopFront();//go to shop front
                            }
                            else
                            {//incorrect entry message
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
                            select = 0;//Red Jandals description page and browse/purchase loop
                            Console.WriteLine("\n\tRed Jandals\n\t These are the kiwi classics you know and love!\n\t Price: $10\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//jed jandels added to cart
                                item = 10;
                                itemName = "\t:Red Jandals\n";
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
                                        ShopShoes();
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
                            Console.WriteLine("\n\tRed Slippers\n\t These comfy fluffy ankle booties are perfect for those long winter nights\n\t Price: $12\n\t");
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
                            Console.WriteLine("\n\tYellow Slides\n\t These comfy cushiony slides are like walking on clouds\n\t You can wear your socks at the same time, we won't judge.\n\t Price: $20");
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
                //display Accesories menu with prices and select numbers
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
                        {//Red sunglasses display and purchase loop
                            Console.Clear();
                            Console.WriteLine("\n\tPassionate Red Sunglasses\n\t These heart shaped frames will makes your eyes love you\n\t Price: $20\n");
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
                                        ShopAccesories();
                                    }
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//incorrect entry
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopAccesories();
                            }
                            break;
                        }
                
                    case 2:
                        {//ruby red scarf display and purchase/browse loop
                            Console.Clear();
                            Console.WriteLine("\n\tRuby Red Scarf\n\t Warming wool scarfy to protect you from any winter chills\n");
                            Console.WriteLine("\t To purchase                     -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Accesories  -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add scarf to cart
                                item = 15;
                                item = 80;
                                itemName = "\t:Red Scarf\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display message item has been added to cart check out or continue shopping
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = 0;
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//to purchase now
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                               
                            }
                            if (select == 2)
                            {
                                ShopAccesories();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid 
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopAccesories();
                            }
                            break;
                        }

                    case 3:
                        {//red bucket hat display, add to cart or browse
                            Console.Clear();
                            Console.WriteLine("\n\t Red Bucket hat\n\t Brilliant racing car red hat to sheid your eyes from the sun\n");
                            Console.WriteLine("\t To purchase                 -press [1]");
                            Console.WriteLine("\t To return to Browse Accesories -press [2]");
                            Console.WriteLine("\t To return to Shop Front     -press [3]");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 25;
                                itemName = "\t:Red Bucket hat\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart checkout or continue shopping?
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//to purchase
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront(); //continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopAccesories();
                            }
                            break;
                        }

                    case 4:
                        {//Red simberro display menu and purchase loop
                            Console.Clear();
                            Console.WriteLine("\n\tRed Simberro\n\t Vibrant hat with extra wide brim to keep you shelter from the fierce sun.\n\t Price: $20\n");
                            Console.WriteLine("\t To purchase                     -Press [1]");
                            Console.WriteLine("\t To return to Browse Accesories  -Press [2]");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 20;
                                itemName = "\t:Red Simbrerro\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart message
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//to buy
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                        ShopAccesories();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopAccesories();
                            }
                            break;
                        }
                    case 5:
                        {//yelloe socks display and purchase method
                            Console.Clear();
                            Console.WriteLine("\n\tYellow Socks\n \tComfy cosey Yellow socks that will make your feet happy\n");
                            Console.WriteLine("\t To purchase                     -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Accesories  -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 5;
                                itemName = "\t:Yellow Socks\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//to buy now
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopAccesories();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                        ShopAccesories();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopAccesories();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopAccesories();
                            }
                            break;
                        }
                    case 6:
                        {
                            ShopFront();//continue shopping
                            break;
                        }
                    default:
                        {//invalid
                            Console.Clear();
                            Console.WriteLine("\n\t Entry invalid please try again.");
                            select = 0;
                            break;

                        }//end default
                }//end switch
            }//end while
        }//end void
        public static void ShopJewelery()//buy your jewelery here!
        {
            Console.Clear();
            select = 0;
            while (select == 0)
            {//display jewelery menu with prices and select numbers
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
                        {//rose gold drop earrings display and purchase loop
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Drop Earrings\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                       -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery      -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front           -Press [3]\n");
                            Console.WriteLine("\n\n\tPlease select from the options above.");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 15;
                                itemName = "\t:Rose Gold Drop Earrings\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2] ");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//buy now
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                        ShopJewelery();
                                    }
                                    
                                }

                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopJewelery();
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();//rose gold necklace display and purchase menu
                            Console.WriteLine("\n\tRose gold Necklance\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                       -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery      -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front           -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 14;
                                item = 80;
                                itemName = "\t:Rose Gold Necklace\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out          -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping  -Press [2] ");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//buy now
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopJewelery();
                            }
                            break;
                        }

                    case 3:
                        {//rose gold studs dispaly browse and purchase menu
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Studs\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                   -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery  -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front       -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 10;
                                itemName = "\t:Rose Gold Studs\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart message buy now or continue shopping menu
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out            -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping    -Press [2] ");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//buy now
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                        ShopJewelery();

                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {//invalid
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopJewelery();
                            }
                            break;
                        }
                    case 4:
                        {//Rose gold bangles display and purchase/browse menu
                            Console.Clear();
                            Console.WriteLine("\n\tRose gold Bangles\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                     -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery    -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front         -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {//add to cart
                                item = 15;
                                itemName = "\t:Rose Gold Bangles\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {//display add to cart, check out now or continue shopping
                                    Console.Clear();
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.");
                                    Console.WriteLine("\n\t To check out                     -Press [1]");
                                    Console.WriteLine("\n\t To continue shopping Jewelery    -Press [2]");
                                    Console.WriteLine("\n\t To continue shopping shop front  -Press [2]");
                                    Console.WriteLine("\n\n\tPlease select from the options above.");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Checkout();//buy now
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        ShopJewelery();//continue shopping
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        ShopFront();//continue shopping
                                        break;
                                    }
                                    else
                                    {//invalid
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                        ShopJewelery();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                ShopJewelery();//continue shopping
                            }
                            if (select == 3)
                            {
                                ShopFront();//continue shopping
                            }
                            else
                            {
                                //incorrect entry try again
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopJewelery();
                            }
                            break;
                        }
                    case 5:
                        {
                            //Rose gold broach browsing menu
                            Console.Clear();
                            //display description
                            Console.WriteLine("\n\tRose gold Broach\n\t Simple oval, with a emerald gem in the centre\n");
                            //display menu options moving forward
                            Console.WriteLine("\t To purchase                        -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery       -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front            -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                //define current item name and cost
                                item = 8;
                                itemName = "\t:Rose gold Broach\n";
                                //add item name and cost to cart
                                Cart += item;
                                Cartitems += itemName;

                                while (1==1)
                                {
                                    Console.Clear();
                                    //display what has been added to cart
                                    Console.WriteLine($"\n\t{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = int.Parse(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        //go to checkout loop
                                        Checkout();
                                        break;
                                    }
                                    if (select == 2)
                                    {
                                        //go to jewelery menu
                                        ShopJewelery();
                                        break;
                                    }
                                    if (select == 3)
                                    {
                                        //go to shop front
                                        ShopFront();
                                        break;
                                    }
                                    else
                                    {
                                        //incorrect entry try again
                                        Console.Clear();
                                        Console.WriteLine("\n\tIncorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                        ShopJewelery();
                                    }
                                    
                                }
                                
                            }
                            if (select == 2)
                            {
                                //go to jewelery shop menu
                                ShopJewelery();
                            }
                            if (select == 3)
                            {
                                //go to shop front
                                ShopFront();
                            }
                            else
                            {
                                //incorrect entry try again
                                Console.Clear();
                                Console.WriteLine("\n\tIncorrect entry Please try again, Press any key to continue.");
                                Console.ReadKey();
                                ShopShoes();
                            }
                            break;
                        }

                    case 6:
                        {
                            //go to Shop front
                            ShopFront();
                            break;
                        }

                    default:
                        {
                            //incorrect entry try again
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
            Console.WriteLine($"\n\tYour current balance is [${balence}].\n\n\t To top up             -Press [1]\n\t To continue shopping  -Press [2]");
            select = 0;
            select= int.Parse(Console.ReadLine());

            while (select != 0)
            {
                if (select == 1)

                {
                    Console.WriteLine("Please enter top up amount");
                    TopUpAmount = int.Parse(Console.ReadLine());

                    if (TopUpAmount > 0)//check topup amount is not 0 or less than 0
                    {
                        Console.Clear();
                        balence = balence + TopUpAmount;//add top up to balance
                                                        //top up successful display new balance redirect to continue shopping
                        Console.WriteLine($"\n\tYour balance has been updated your new balance is [${balence}].\n\n\t If you would like to now checkout find your cart on the shop front menu!\n\n\t Press any key to return to the shop front");
                        Console.ReadKey();
                        ShopFront();
                    }
                    else
                    {
                        //insuffiecient funds sequence
                        Console.Clear();
                        Console.WriteLine($"\n\t${TopUpAmount} is an invalid Top up amount.\n\t Press any key to try again");
                        Console.ReadKey();
                        TopUp();//force top up
                    }
                }

                if (select == 2)
                {
                    ShopFront();

                }

                else
                {
                    Console.WriteLine("Incorrect entry please select either 1 or 2. Press any key to try again");
                    Console.ReadKey();
                    TopUp();
                }
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

        public static void LoginLoop()//login is a simple username r or R works no password required 
        {
            usernameWhile = true;
            while (usernameWhile == true)
            {
                Console.WriteLine("\tPlease enter a username.");//request username
                username = Console.ReadLine();//store input as username
                if ((username.Equals(storedUsername, StringComparison.OrdinalIgnoreCase)))// check username matches stored username
                // lower case or uppercase r/R will work for the username!
                {
                    Console.Clear();
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
                        Console.ReadKey();//waits to ensure ueser knows why the program quits
                        Environment.Exit(0);
                    }
                }

            }
        }
    



        static void Main(string[] args)
        {
        
                Console.Clear();
                Console.WriteLine("\t♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥");//welcome title
                Console.WriteLine("\t\t\tWelcome to Live, Laugh, love.");
                Console.WriteLine("\t♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n");
                attempts = 0;
            //welcome message
            Console.WriteLine("\tLive, laugh, love is dedicated to making your shopping experience enjoyable!\n\t We sell only the highest quality shoes, jewelery and accesories!\n");
            //prompt login loop
            Console.WriteLine("\n\tPress any key to login");
                Console.ReadKey();
       
                LoginLoop();//go to login loop
    
    
        }
    }
}
