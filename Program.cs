namespace Lab_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bird bird = new Bird("eagle");
            bird.LeftWing.WingStatus = WingStatus.OPENED;
            bird.RightWing.WingStatus = WingStatus.OPENED;
            bird.attac();
            bird.fly();
        }
    }
}