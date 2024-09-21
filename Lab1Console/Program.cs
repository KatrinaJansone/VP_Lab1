using Lab1Library;

namespace Lab1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studData = new StudentsData();
                studData.Load(StudentsData.DefaultFilename);
                foreach (var stud in studData.Students)
                    System.Console.WriteLine(stud);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            System.Console.ReadLine();
        }
    }
}