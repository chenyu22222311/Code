using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mymoney : MonoBehaviour
{
    public  int  money;
    public static bool isBuildmodel = true;
    // Start is called before the first frame update
    public void Money(int i)
    {
        if (money + i >= 0)
        {
            isBuildmodel = true;
            money += i;
            GetComponent<Text>().text = "" + money;
        }
        else
        {
            isBuildmodel = false;
            GetComponent<Text>().text = "" + money;
        }
    }
}
