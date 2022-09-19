﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_shop
{
    internal class Program
    {
        //global variables
        public static string username ="";
        public static int balence = 100;
        public static int TopUpAmount = 0;
        public static int select = 0;
        public static int Cart = 0;
        public static string itemName = "";
        public static string Cartitems = "";
        public static int item = 0;

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
        select =int.Parse(Console.ReadLine());

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
                        select = 0;
                        while (select == 0)
                        {
                            Console.WriteLine($"\n\n\t Your Cart total is ${Cart} With the following items\n\t{Cartitems}.\n\t To check out        -Press [1]\n\t To continue shoping -Press [2].\n\t To clear cart       -Press [3].\n");
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
                                Console.WriteLine("Your cart is now empty to continue shopping Press any key.");
                                Console.ReadKey();
                                ShopFront();
                                break;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Entry invalid press any key to try again.");
                                select = 0;
                                Console.ReadKey();
                            }
                        }

                        
                        ShopFront();
                   break;
                }
            default:
                {
                    Console.WriteLine("\t Entry invalid please try again.");
                    select = 0;
                    ShopFront();
                    break;

                }
        }


            

           
        }
        public static void ShopShoes()
        {
            Console.Clear();
            select = 0;
            while (select== 0)
            {
                Console.WriteLine("\n\t♥♥♥Shoes♥♥♥\n");
                Console.WriteLine("\tRed Steletos           [$80.00]  -Press [1]\n");
                Console.WriteLine("\tWhite fashion Sneakers [$100.00] -Press [2]\n");
                Console.WriteLine("\tRed Jandels            [$10.00]  -Press [3]\n");
                Console.WriteLine("\tRed Slippers           [$12.00]  -Press [4]\n");
                Console.WriteLine("\tYellow Slides          [$25.00]  -Press [5]\n");
                Console.WriteLine("\tReturn to Shop Front             -Press [6]\n");
                Console.WriteLine("\tPlease select from the above options");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        {
                            Console.Clear();
                            select = 0;
                            Console.WriteLine("\tRed Steletos\n\t These comfy 4 inch pumps will help you dance the night away\n");
                            Console.WriteLine("\t To purchase                 -press [1]");
                            Console.WriteLine("\t To return to Browse Shoes -press [2]");
                            Console.WriteLine("\t To return to Shop Front     -press [3]");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 80;
                                itemName = "\t:Red Steletos\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
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
                                Console.WriteLine("\tIncorrect entry Please try again.");
                                ShopShoes();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\tWhite sneakers\n\t These faux leather sneakers are scratch and dirt resistent, the perfect accompaniyment for any outfit\n");
                            Console.WriteLine("\t To purchase                 -press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 100;
                                itemName = "\t:White Fashion Sneakers\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = 0;
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                            
                                    break;
                                }
                                break;
                             }
                            break;
                         } 

                    case 3:
                        {
                            Console.Clear();
                            select = 0;
                            Console.WriteLine("\tRed Jandels\n\t These are the kiwi classics you know and love\n");
                            Console.WriteLine("\t To purchase                 -press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 10;
                                itemName = "\t:Red Jandels\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    select = 0;
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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

                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                             break;
                            }
                         break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRed Slippers\n\t These comfy fluffy ankle booties are perfect for those long winter nights\n");
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

                                while (true)
                                {
                                    select = 0;
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRed Slides\n\t These comfy cushiony slides are like walking on clouds, plus you can wear your socks at the same time, we won't judge\n");
                            Console.WriteLine("\t To purchase                 -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Shoes   -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front     -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 20;
                                itemName = "\t:Red Slides\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    select = 0;
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\t Entry invalid please try again.");
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
               
                Console.WriteLine("\t♥♥♥Accesories♥♥♥\n");
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
                            Console.WriteLine("\tPassionate Red Sunglasses\n\t These heart shaped frames will makes your eyes love you\n");
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

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRuby Red Scarf\n\t Warming wool scarfy to protect you from any winter chills\n");
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

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
                                    select = 0;
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\t Red Bucket hat\n\t Brilliant racing car red hat to sheid your eyes from the sun\n");
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

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            break;
                            }
                         break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRed Simberro\n\t Vibrant hat with extra wide brim to keep you shelter from the fierce sun.\n");
                            Console.WriteLine("\t To purchase                 -press [1]");
                            Console.WriteLine("\t To return to Browse Accesories -press [2]");
                            Console.WriteLine("\t To return to Shop Front     -press [3]");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 20;
                                itemName = "\t:Red Simbrerro\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\tYellow Socks\n \tComfy cosey Yellow socks that will make your feet happy\n");
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

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
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
                            Console.WriteLine("\t Entry invalid please try again.");
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
                            Console.WriteLine("\tRose gold Drop Earrings\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                       -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery      -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front           -Press [3]\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 15;
                                itemName = "\t:Rose Gold Drop Earrings\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                break;
                            }
                        break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRose gold Necklance\n\t Simply romantic, beatifully classy\n");
                            Console.WriteLine("\t To purchase                       -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery      -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front           -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 14;
                                item = 80;
                                itemName = "\t:Red Steletos\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
                            }
                        break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRose gold Studs\n\t Simply romantic, beatifully classy\n");
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

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRose gold Bangles\n\t Simply romantic, beatifully classy\n");
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

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\tRose gold Broach\n\t Simple oval, with a emerald gem in the centre\n");
                            Console.WriteLine("\t To purchase                        -Press [1]\n");
                            Console.WriteLine("\t To return to Browse Jewelery       -Press [2]\n");
                            Console.WriteLine("\t To return to Shop Front            -Press [3]\n");
                            Console.WriteLine("\t Please select from the above options\n");
                            select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                item = 8;
                                item = 80;
                                itemName = "\t:Red Steletos\n";
                                Cart += item;
                                Cartitems += itemName;

                                while (true)
                                {
                                    Console.WriteLine($"{itemName} ${item} has been added to your cart.\n\t To check out           Press [1]\n\t To continue shopping Press [2] ");
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
                                    else
                                    {
                                        Console.WriteLine("Incorrect entry please try again. Press any key to continue.");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                                break;
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
                            Console.WriteLine("\t Entry invalid please try again.");
                            select = 0;
                            break;

                        }//end default
                }//end switch
            }//end while
        }//end void

        public static void TopUp()
        {
         Console.Clear();
         Console.WriteLine($"Your current balence is [${balence}]. Enter your Top up amount.");
         TopUpAmount= int.Parse(Console.ReadLine());

           if (TopUpAmount>0)
            {
             balence = balence + TopUpAmount;
            Console.WriteLine($"\tYour balence has been up dated your new balence is [${balence}].\n\t Press any key to return to the shop front");
                Console.ReadKey();
                ShopFront();
            }
           else
            {
                Console.WriteLine("That is an invalid TopUp amount.\n\t Press any key to try again");
                TopUp();
            }
        }

        public static void Checkout()
        {
            Console.Clear();
            if (Cart <= balence)
            {
                Console.WriteLine($" you are purchasing the following \n{Cartitems} \n\t Toal = ${Cart}");
                Console.WriteLine($"\n\n\t Transaction approved your new balance is ${balence -= Cart}.\n");
                Console.WriteLine($"\tHave as great day {username}! Thanks for shoping with Live, Laugh, Love.\n\t Press any Key to Return to Shop Categories.");
                Console.ReadKey();
                select = 0;
                Cart = 0;
                Cartitems = "";
                ShopFront();
            }
            else
            {
                Console.WriteLine($"\t Your balence [${balence}] is insuffiecient for that purchase [${Cart}] please Top up.");
                Console.WriteLine("\tPress any key to open top up menu.");
                Console.ReadKey();
                TopUp();
            }
        }




        static void Main(string[] args)
        {
            while (username == "")
            {
                Console.Clear();
                Console.WriteLine("\t♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥");
                Console.WriteLine("\t\tWelcome to Live, Laugh, love.");
                Console.WriteLine("\t♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥\n");
                Console.WriteLine("\tPlease enter a username.");
                username = Console.ReadLine();

                if (username != "")
                {
                    Console.WriteLine($"\tWelcome {username}!");
                    Console.WriteLine("\tTo welcome you we have topped up your store credit, enjoy!");
                    Console.WriteLine("\t________________________________________\n");
                    Console.WriteLine($"\t Your current balence is ${balence}.\n");
                    Console.WriteLine("\t________________________________________\n");
                    Console.WriteLine("\tLet's get shopping press any key to start!");
                    Console.ReadKey();
                    ShopFront();
                }
                else
                {
                    Console.WriteLine("\t Username invalid prease try again.");

                }
            }


        }
    }
}