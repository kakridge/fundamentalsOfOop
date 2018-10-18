using System;

namespace FundamentalsOfOop
{
    public class TimeMachineSimulator
    {
        public void Simulate()
        {
            Console.WriteLine("Welcome to the Time Machine Simulator\n");
            Console.ReadLine();
            var delorean = new Delorean();
            Console.WriteLine("Cool, I found this weird looking Delorean.  Let's see how fast this thing can go.");
            var outcome = delorean.Accelerate();
            Console.ReadLine();
            Console.WriteLine($"Great Scott!  I've been transported to {outcome}");
        }
    }
}