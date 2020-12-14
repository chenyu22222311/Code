using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{  //状态模式
   public abstract class State
    {
        public abstract void Handle(Context context);
        
    }
    public class Context
    {
        public State state;
        public Context(State state)
        {
            this.state = state;
        }
        public void Request()
        {
            state.Handle(this);
        }

    }
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("当前的状态是A");
            context.state = new ConcreteStateB();
        }
    }
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("当前的状态是B");
            context.state = new ConcreteStateA();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            Console.ReadLine();
        }
    }
}
