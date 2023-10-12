namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle size = new Circle(5); //Här skapar vi objektet som är kopplat till circle klassen
            size.GetArea(); //Här anropar vi metoden 
            Circle size2 = new Circle(6);
            size2.GetArea();

        }
    }
}