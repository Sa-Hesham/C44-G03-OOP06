using assignment.Proj1;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region project1
            Point3D p1 = new Point3D(10, 10, 10);
            Console.WriteLine(p1.ToString());

            Console.WriteLine("Enter coordinates for Point P1:");
            Console.WriteLine("Enter X:");
            string ?x=Console.ReadLine();
            int x1 = utalityParse.ReadIntoTryParse(x);
            Console.WriteLine("Enter y:");
            string? y = Console.ReadLine();
            int y1 = utalityParse.ReadParse(y);
            Console.WriteLine("Enter x:");
            string? z = Console.ReadLine();
            int z1 =utalityParse.ReadConvert (z);
            Point3D P2 = new Point3D(x1, y1, z1);

            if (p1 == P2)
            {
                Console.WriteLine("they are same ");
            }else
            {
                Console.WriteLine("differant");
            }

            Point3D[] arr = new Point3D[2]
            {
                p1,P2
            };

            Console.WriteLine("Before sorting:");
            foreach (var p in arr)
                Console.WriteLine(p);

         
            Array.Sort(arr);

            Console.WriteLine("\nAfter sorting (by X, then Y):");
            foreach (var p in arr)
                Console.WriteLine(p);
            #endregion
        }
    }
}
