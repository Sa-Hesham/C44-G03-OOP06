using assignment.Proj1;
using assignment.project2;
using assignment.Project3;
using Math = assignment.project2.Math;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region project1
            //Point3D p1 = new Point3D(10, 10, 10);
            //Console.WriteLine(p1.ToString());

            //Console.WriteLine("Enter coordinates for Point P1:");
            //Console.WriteLine("Enter X:");
            //string ?x=Console.ReadLine();
            //int x1 = utalityParse.ReadIntoTryParse(x);
            //Console.WriteLine("Enter y:");
            //string? y = Console.ReadLine();
            //int y1 = utalityParse.ReadParse(y);
            //Console.WriteLine("Enter x:");
            //string? z = Console.ReadLine();
            //int z1 =utalityParse.ReadConvert (z);
            //Point3D P2 = new Point3D(x1, y1, z1);

            //if (p1 == P2)
            //{
            //    Console.WriteLine("they are same ");
            //}else
            //{
            //    Console.WriteLine("differant");
            //}

            //Point3D[] arr = new Point3D[2]
            //{
            //    p1,P2
            //};

            //Console.WriteLine("Before sorting:");
            //foreach (var p in arr)
            //    Console.WriteLine(p);


            //Array.Sort(arr);

            //Console.WriteLine("\nAfter sorting (by X, then Y):");
            //foreach (var p in arr)
            //    Console.WriteLine(p);
            #endregion


            #region project2
            //try
            //{
            //    Console.WriteLine(Math.Divide(20, 0));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine( ex.Message);
            //}


            #endregion



            #region Project 3 

        //    Console.WriteLine("=== Welcome to Our Store ===");
        //    Console.WriteLine();

        //    // Get user type and create appropriate user object
        //    User user = GetUserFromInput();

        //    // Get product details from user
        //    Console.WriteLine();
        //    decimal price = GetProductPrice();
        //    int quantity = GetProductQuantity();

        //    // Calculate discount and final price
        //    Discount discount = user.GetDiscount();
        //    decimal discountAmount = discount.CalculateDiscaount(price, quantity);
        //    decimal totalBeforeDiscount = price * quantity;
        //    decimal finalPrice = totalBeforeDiscount - discountAmount;

        //    // Display results
        //    DisplayResults(user, discount, price, quantity, totalBeforeDiscount, discountAmount, finalPrice);

        //    Console.WriteLine();
        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey();
        //}

        //static User GetUserFromInput()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Please select your user type:");
        //        Console.WriteLine("1. Regular User (5% discount)");
        //        Console.WriteLine("2. Premium User ($100 flat discount)");
        //        Console.WriteLine("3. Guest User (no discount)");
        //        Console.Write("Enter your choice (1-3): ");

        //        string choice = Console.ReadLine();

        //        if (choice == "1")
        //        {
        //            Console.Write("Enter your name: ");
        //            string regularName = Console.ReadLine();
        //            return new RegularUser(regularName);
        //        }
        //        else if (choice == "2")
        //        {
        //            Console.Write("Enter your name: ");
        //            string premiumName = Console.ReadLine();
        //            return new PremiumUser(premiumName);
        //        }
        //        else if (choice == "3")
        //        {
        //            return new GuestUser();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
        //            Console.WriteLine();
        //        }
        //    }
        //}

        //static decimal GetProductPrice()
        //{
        //    while (true)
        //    {
        //        Console.Write("Enter product price: $");
        //        string input = Console.ReadLine();

        //        decimal price;
        //        bool isValidPrice = decimal.TryParse(input, out price);

        //        if (isValidPrice && price > 0)
        //        {
        //            return price;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter a valid positive price!");
        //        }
        //    }
        //}

        //static int GetProductQuantity()
        //{
        //    while (true)
        //    {
        //        Console.Write("Enter quantity: ");
        //        string input = Console.ReadLine();

        //        int quantity;
        //        bool isValidQuantity = int.TryParse(input, out quantity);

        //        if (isValidQuantity && quantity > 0)
        //        {
        //            return quantity;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter a valid positive quantity!");
        //        }
        //    }
        //}

        ////method to display
        //static void DisplayResults(User user, Discount discount, decimal price, int quantity,
        //                          decimal totalBeforeDiscount, decimal discountAmount, decimal finalPrice)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("==================================================");
        //    Console.WriteLine("user Info");
        //    Console.WriteLine("==================================================");

        //    Console.WriteLine("Customer: " + user.Name);
        //    Console.WriteLine("User Type: " + user.GetType().Name);
        //    Console.WriteLine("Discount Applied: " + discount.Name);

        //    Console.WriteLine();
        //    Console.WriteLine("Product Details:");
        //    Console.WriteLine("Price per item: $" + price.ToString("F2"));
        //    Console.WriteLine("Quantity: " + quantity);
        //    Console.WriteLine("Total before discount: $" + totalBeforeDiscount.ToString("F2"));

        //    Console.WriteLine();
        //    Console.WriteLine("Discount Calculation:");
        //    Console.WriteLine("Discount amount: $" + discountAmount.ToString("F2"));
        //    Console.WriteLine("Final price: $" + finalPrice.ToString("F2"));

        //    if (discountAmount > 0)
        //    {
        //        decimal savingsPercent = (discountAmount / totalBeforeDiscount) * 100;
        //        Console.WriteLine("You saved: " + savingsPercent.ToString("F1") + "% ($" + discountAmount.ToString("F2") + ")");
        //    }

        //    Console.WriteLine("==================================================");
    
                 #endregion
    }
    }
}
