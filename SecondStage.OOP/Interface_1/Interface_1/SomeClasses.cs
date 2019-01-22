using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Man : IBreathe, IThink, IMoveVoice
    {
        public Man(string name)
        {
            GetName = name;
        }
        public string GetName { get; }

        public bool Breathe()
        {
            return true;
        }

        public void Move()
        {
            Console.WriteLine("Can move on his two legs");
        }

        public void Think()
        {
            Console.WriteLine("Thinks a lot");
        }

        public void Voice()
        {
            Console.WriteLine("Can speak");
        }
    }
    class Porshe : IMoveVoice
    {
        public Porshe(string name)
        {
            GetName = name;
        }
        public string GetName { get; }

        public void Move()
        {
            Console.WriteLine("Moves on 4 wheels");
        }

        public void Voice()
        {
            Console.WriteLine("Has signal");
        }
    }
    class Dog : IBreathe, IMoveVoice
    {
        public Dog(string name)
        {
            GetName = name;
        }
        public string GetName { get; }

        public bool Breathe()
        {
            return true;
        }

        public void Move()
        {
            Console.WriteLine("Can move on his four legs");
        }

        public void Voice()
        {
            Console.WriteLine("Can bark");
        }
    }
    class Bird : IBreathe, IMoveVoice
    {
        public Bird(string name)
        {
            GetName = name;
        }
        public string GetName { get; }

        public bool Breathe()
        {
            return true;
        }

        public void Move()
        {
            Console.WriteLine("Can fly");
        }

        public void Voice()
        {
            Console.WriteLine("Can tweet");
        }
    }
}
