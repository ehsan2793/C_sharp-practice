namespace InheritanceChallenge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Rahimi", "ehsan", 10002);
            employee1.WorK();
            employee1.Pause();

            Boss boss1 = new Boss("Rahimi", "ehsan", 1000, "toyota");
            boss1.Lead();
            boss1.WorK();


            Trainess trainess1 = new Trainess("Rahimi", "ehsan", 1000, 100, 200);
            trainess1.WorK();
            trainess1.Learn();
        }
    }
}