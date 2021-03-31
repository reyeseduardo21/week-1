using sc = System.Console;

namespace Revature.Week1.HelloWorld //namespace scope
{
    //class, struct, interface, enum
    class Program // class scope
    {
        private static void Main()
        {
            sc.WriteLine("Enter your name:");
            //stdin to get your name
            var input = sc.ReadLine(); // datatype inference
            //stdout to print your name

            sc.WriteLine($"Hello {input}");
        }
        private void UiPath()
        { //method scope
            { //block scope

            }

        }
    }
}