using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_4
{
    class College
    {
        private string name;
        protected string uni_name;
        public string department;

        public College(string name, string uni_name, string department)
        {
            this.name = name;
            this.uni_name = uni_name;
            this.department = department;
        }
        public void DisplayName()
        {
            Console.WriteLine("Name of the College : " + name);
        }
        public void DisplayUniName()
        {
            Console.WriteLine("University Name : " + uni_name);
        }
        public void DisplayDepName()
        {
            Console.WriteLine("Department Name : " + department);
        }
        public void Display()
        {
            DisplayName();
            DisplayUniName();
            DisplayDepName();
        }
    }
    class SOE : College
    {
        private string Event_name;
        protected int Cost_of_Event;
        public string coordinator_name;

        public SOE(string name,string uni_name,string department,string Event_name, int Cost_of_Event, string coordinator_name) : base(name, uni_name, department)
        {
            this.Event_name = Event_name;
            this.Cost_of_Event = Cost_of_Event;
            this.coordinator_name = coordinator_name;
        }
        public void DisplayEventName()
        {
            Console.WriteLine("Event Name : " + Event_name);
        }
        public void DisplayCostOfEvent()
        {
            Console.WriteLine("Cost of Event : " + Cost_of_Event);
        }
        public void DisplayCordName()
        {
            Console.WriteLine("Coordinator Name : " + coordinator_name);
        }

        public void DisplaySOE()
        {
            DisplayEventName();
            DisplayCostOfEvent();
            DisplayCordName();
        }
    }
    internal class P3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Agravat Prem 25SOECE13042");
            SOE s1 = new SOE("Global","RKU","Computer Science","Techno_Planet",10000,"Rairaj");
            s1.Display();
            s1.DisplaySOE();

            SOE s2 = new SOE("Nobla", "GTU", "Nurshing", "Blood Donation", 10000, "Rairaj");
            s2.Display();
            s2.DisplaySOE();
            Console.ReadLine();

        }
    }
}
