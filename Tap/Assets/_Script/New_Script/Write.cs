using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public struct GameRecord
{
    public int number;
    public string result;
    public int index;
}

public class Write : MonoBehaviour
{
    public Text Result;
    public Mymoney other;
    public Text text;
    public GameObject canvas;
    public bool isbool = true;
  

    public void zhixing()
    {
        CunDang();
        Chakan();
    }
    public void CunDang()
    {
        GameRecord gameRecord;
        gameRecord.number = other.money;
        gameRecord.result = Result.text;
        gameRecord.index = SceneManager.GetActiveScene().buildIndex;
        ExampleClass.list.Add(gameRecord);
    }

    public void Chakan()
    {
       
        for (int i = 0; i < ExampleClass.list.Count; i++)
        {
            if (ExampleClass.list[i].index== SceneManager.GetActiveScene().buildIndex)
            {
                text.text = text.text + "金币数量：" + ExampleClass.list[i].number + ";" + "比赛结果：" + ExampleClass.list[i].result + " ";
            }        
        } 
       
    }

    public void xianshi()
    {
        if (isbool)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
        isbool = !isbool;
    }
}
