namespace Chap04Ex0203RectangleCalc {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Rectangle Calculator App!");

            // get input - length: double, width: double
            Console.Write("Enter length: ");
            decimal length = Decimal.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            decimal width = Decimal.Parse(Console.ReadLine());

            // do biz logic
            // - calc area: length * width
            // - calc perimeter: 2 * length + 2 * width
            decimal area = length * width;
            decimal perimeter = 2 * length + 2 * width;

            // display output
            // - output area and perimeter
            Console.WriteLine("Area:\t\t" + area);
            Console.WriteLine("Perimeter:\t" + perimeter);

            Console.WriteLine("Bye");
        }
    }
}
