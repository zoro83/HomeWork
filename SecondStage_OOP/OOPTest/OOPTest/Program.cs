using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    interface IInterface
    {
        void MyMethod();
    }
    public abstract class Abstract : IInterface
    {
        public abstract void MyMethod();

        void IInterface.MyMethod()
        {
            throw new NotImplementedException();
        }

        public Abstract()
        {
            Console.WriteLine("Abstract");
        }
        
        public abstract int MyProperty { get; set; }
    }

   public class Derived1 : Abstract
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void MyMethod()
        {
            Console.WriteLine("Der1 implementation");
        }
        public Derived1()
        {
            Console.WriteLine("der1");
        }
    }
     public class Derived2 : Derived1
    {
        public Derived2()
        {
            Console.WriteLine("der2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived2 derived2 = new Derived2();
            Derived1 derived1 = new Derived1();
            derived1.MyMethod();
            Abstract @abstract = derived1 as Abstract;
            @abstract.MyMethod();
            Console.WriteLine(@abstract.GetHashCode());
            Console.WriteLine(derived1.GetHashCode());
            IInterface @interface = @abstract as Abstract;
            Console.WriteLine(@interface.GetHashCode());
            Console.ReadKey();

        }
        
    }
}
