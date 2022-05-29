namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new Student[] {new Student(), new Aspirant(), new Student()};
            foreach (var item in array)
            {
                Console.WriteLine(item.getScholarship());
            }


        }
    }
}