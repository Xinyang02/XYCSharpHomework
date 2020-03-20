using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    public delegate void TickHandler();
    public delegate void AlarmHandler();
    public class ClockEvent
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        public void Tick()
        {
           // Console.WriteLine(DateTime.Now.ToString("hh+mm+ss"));
            OnTick();
        }
        public void Alarm()
        {           
            OnAlarm();
        }
    }

    public class Clock
    {
        public ClockEvent clock1 = new ClockEvent();
        //String time;
        public Clock()
        {
            
            clock1.OnTick += printTime;
            clock1.OnAlarm += Clock1_OnAlarm;
        }

        private void Clock1_OnAlarm()
        {
            Console.WriteLine("整点报时！");
        }

        void printTime()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String s=DateTime.Now.ToString("hh+mm+ss");
            Clock a = new Clock();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                a.clock1.Tick();               
                if(int.Parse(DateTime.Now.Second.ToString()) == 0)
                {
                    a.clock1.Alarm();
                }             
            }
        }
    }
}
