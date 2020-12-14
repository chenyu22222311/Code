using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract void WFvfds(GameObject gameObject, Mymoney my, int index);
}
public class State01 : State
{
    public override void WFvfds(GameObject gameObject, Mymoney my, int index)
    {
        if (gameObject.tag=="01")
        {
            if (index == 1)
            {
                my.Money(-100);
            }
            else if (index == 2)
            {
                my.Money(-180);
            }
            else if (index == 3)
            {
                my.Money(80);
            }
            else if (index == 4)
            {
                my.Money(224);
            }
        }
        else
        {
            new State02().WFvfds(gameObject,my,index);
        }
    }
}
public class State02 : State
{
    public override void WFvfds(GameObject gameObject, Mymoney my, int index)
    {
        if (gameObject.tag == "02")
        {
            if (index == 1)
            {
                my.Money(-120);
            }else if (index == 2)
            {
                my.Money(-200);
            }
            else if (index == 3)
            {
                my.Money(96);
            }
            else if (index == 4)
            {
                my.Money(272);
            }
        }
        else
        {
            new State03().WFvfds(gameObject, my, index);
        }
    }
}
public class State03 : State
{
    public override void WFvfds(GameObject gameObject, Mymoney my, int index)
    {
        if (gameObject.tag == "03")
        {
            if (index == 1)
            {
                my.Money(-160);
            }
            else if (index == 2)
            {
                my.Money(-240);
            }
            else if (index == 3)
            {
                my.Money(128);
            }
            else if (index == 4)
            {
                my.Money(312);
            }
        }
        else
        {
            new State04().WFvfds(gameObject, my, index);
        }
    }
}
public class State04 : State
{
    public override void WFvfds(GameObject gameObject, Mymoney my, int index)
    {
        if (gameObject.tag == "04")
        {
            if (index == 1)
            {
                my.Money(-180);
            }
            else if (index == 2)
            {
                my.Money(-260);
            }
            else if (index == 3)
            {
                my.Money(156);
            }
            else if (index == 4)
            {
                my.Money(324);
            }
        }
      
    }
}
