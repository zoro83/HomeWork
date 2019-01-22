using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Kamo");
            Porshe porshe = new Porshe("Cayenne");
            Dog dog = new Dog("Sharik");
            Bird bird = new Bird("Sparrow");

            IBreathe[] br = { man as IBreathe, porshe as IBreathe, dog as IBreathe, bird as IBreathe };
            for (int i = 0; i < br.Length; i++)
            {
                if (br[i] != null)
                {
                    Console.WriteLine($"{br[i].GetType().Name} can breath: {br[i].Breathe()}");
                }
            }
            IThink[] th = { man as IThink, porshe as IThink, dog as IThink, bird as IThink };
            for (int i = 0; i < br.Length; i++)
            {
                if (th[i] != null)
                {
                    Console.Write($"{th[i].GetType().Name}: ");
                    th[i].Think();
                }
            }
            IMoveVoice[] mv = { new Man("Peto"), new Porshe("Boxster"), new Dog("Jenny"), new Bird("Eagle") };
            for (int i = 0; i < br.Length; i++)
            {
                if (mv[i] is IMoveVoice)
                {
                    Console.Write($"{mv[i].GetType().Name}: ");
                    mv[i].Move();
                    Console.Write($"{mv[i].GetType().Name}: ");
                    mv[i].Voice();
                }
            }
            Console.ReadKey();
        }
    }
}
