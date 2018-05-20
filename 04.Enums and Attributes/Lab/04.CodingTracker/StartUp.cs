namespace _04.CodingTracker
{
    [SoftUni("Vasil")]
    public class StartUp
    {
        [SoftUni("Gosho")]
        public static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}