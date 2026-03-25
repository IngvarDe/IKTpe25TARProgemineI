namespace Inheritance2
{
    class Lake : Water
    {
        public override void DoSomething()
        {
            Console.WriteLine("Lake method and it has " + Flow + " and " + Length + " is in meters");
        }
    }
}
