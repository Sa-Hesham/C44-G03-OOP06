namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            ////Shape shape  = new Rectangle();
            ////// Cannot create an instance of the abstract type or interface 'Shape'
            ////// But You Can Create a Reference From Abstract Class Refer To An Object
            ////// From Class That Inherit and Implement Abstract Class


            //Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 20 };
            //ProcessShape(rectangle);
            ////Console.WriteLine($"Area Of Rectangle = {rectangle.CalcArea()} "); // 200
            ////Console.WriteLine($"Perimeter Of Rectangle = {rectangle.Perimeter} "); // 400

            //Square square = new Square(10);
            //ProcessShape(square);
            ////Console.WriteLine($"Area Of Square = {square.CalcArea()} "); // 40
            ////Console.WriteLine($"Perimeter Of Square = {square.Perimeter} "); // 40

            //Circle circle = new Circle(10);
            //ProcessShape(circle);
            ////Console.WriteLine($"Area Of Circle = {circle.CalcArea()} "); // 314.0
            ////Console.WriteLine($"Perimeter Of Circle = {circle.Perimeter} "); // 62.80  
            #endregion
        }
    }
}
