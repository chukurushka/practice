namespace _2
{
    public class Student
    {
        public string FullName { get; set; }
        public string Date { get; set; }
        public int Group { get; set; }
        public int[] Performance { get; set; }
        public Student()
        {
            FullName = "Шумский Эдуард Игоревич";
            Date = "02.02.2004";
            Group = 623;
            Performance = new int[5] { 2,2,3,2,2 };
        }
    }
}