using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{//建造者模式
    class Tank
    {
        public virtual void TankShoot()
        {
            Console.WriteLine("开始射击");
        }
    }
    class Tank1 : Tank
    {
        public override void TankShoot()
        {
            base.TankShoot();
            Console.WriteLine("我是坦克1,一次发射一枚炮弹.");
        }
    }
    class Tank2 : Tank
    {
        public override void TankShoot()
        {
            base.TankShoot();
            Console.WriteLine("我是坦克2,一次发射一枚炮弹.");
        }
    }
    class Tank3 : Tank
    {
        public override void TankShoot()
        {
            base.TankShoot();
            Console.WriteLine("我是坦克3,一次发射一枚炮弹.");
        }
    }
    interface Fctory
    {
        TankBase CreateTank();
        Tank Createtank();

    }
    class Fctory1 : Fctory
    {
        public TankBase CreateTank()
        {
            return new TankA();
        }
        public Tank Createtank()
        {
            return new Tank1();
        }
    }
    class Fctory2: Fctory
    {
        public TankBase CreateTank()
        {
            return new TankB();
        }
        public Tank Createtank()
        {
            return new Tank2();
        }
    }
    class Fctory3 : Fctory
    {
        public TankBase CreateTank()
        {
            return new TankC();
        }
        public Tank Createtank()
        {
            return new Tank3();
        }
    }
    public class Manager
    {
        public static void Main(string[] args)
        {
            Fctory f1 = new Fctory1();
            f1.CreateTank().TankShoot();
            f1.Createtank().TankShoot();
            Fctory f2 = new Fctory2();
            f2.CreateTank().TankShoot();
            f2.Createtank().TankShoot();
            Fctory f3 = new Fctory3();
            f3.CreateTank().TankShoot();
            f3.Createtank().TankShoot();
            Console.ReadLine();
        }
    }

}
