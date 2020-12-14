using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TankBase
    {
       public virtual void TankShoot()
        {
            Console.WriteLine("开始射击");
        }
    }
    class TankA : TankBase
    {
        public override void TankShoot()
        {
            base.TankShoot();
            Console.WriteLine("我是坦克A,一次发射一枚炮弹.");
        }
    }
    class TankB : TankBase
    {
        public override void TankShoot()
        {
            base.TankShoot();
            Console.WriteLine("我是坦克B,一次发射一枚炮弹.");
        }
    }
    class TankC : TankBase
    {
        public override void TankShoot()
        {
            base.TankShoot();
            Console.WriteLine("我是坦克C,一次发射一枚炮弹.");
        }
    }
    interface TankFctory
    {
        TankBase CreateTank();

    }
    class TankAFctory : TankFctory
    {
        public TankBase CreateTank()
        {
            return new TankA();
        }
    }
    class TankBFctory : TankFctory
    {
        public TankBase CreateTank()
        {
            return  new TankB();
        }
    }
    class TankCFctory : TankFctory
    {
        public TankBase CreateTank()
        {
            return new TankC();
        }
    }
    public class TankManager
    {
        public static void Main(string [] args)
        {
            TankFctory f1 = new TankAFctory();
            f1.CreateTank().TankShoot();
            TankFctory f2 = new TankBFctory();
            f2.CreateTank().TankShoot();
            TankFctory f3 = new TankCFctory();
            f3.CreateTank().TankShoot();
            Console.ReadLine();
        }
    }
}
