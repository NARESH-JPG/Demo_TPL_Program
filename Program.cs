using System;
using System.Threading.Tasks;

namespace Demo_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demmo for task Parallel Library");

            //Task.Factory.StartNew(() =>
            var task0 = new Task(() => 
            {
                Console.WriteLine("this is the first method to create and start a task");

            });
            task0.Start();


            var task1 = new Task(() =>
            {
                Console.WriteLine("Here is the Second Task Created using new Keyboard");
            });

            task0.Wait();
            task1.Start();
            task1.Wait();
            Console.WriteLine("Task is Execution");
            Console.ReadKey();
        }
    }
}
