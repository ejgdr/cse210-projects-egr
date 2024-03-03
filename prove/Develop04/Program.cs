class Program
{
    static public int _selection = 0;
    static void Main(string[] args)
    {
        Menu();
    }
    static public void Menu()
    {     
        while (_selection != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            _selection = int.Parse(Console.ReadLine());
            Console.Clear();
            if (_selection == 1)
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.DisplayGreeting();
                breathing.AskDuration();
                breathing.RunIt();
                breathing.DisplayBreathing();
                breathing.DisplayEndMessage();

            }
            else if (_selection == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity(
                    "Reflection Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.DisplayGreeting();
                reflecting.AskDuration();
                reflecting.RunIt();
                reflecting.DisplayEndMessage();
            }
            else if (_selection == 3)
            {
                ListingActivity listing = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.DisplayGreeting();
                listing.AskDuration();
                listing.RunIt();
                listing.DisplayEndMessage();
            }
            else if (_selection == 4)
            {
                Console.WriteLine("See you later!");
            }
            else
            {
                Console.WriteLine("Wrong input. Please introduce a number according to the menu");
            }
        }
    }
}