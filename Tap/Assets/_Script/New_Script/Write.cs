﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class Write : MonoBehaviour
{
    public Text Result;
    public Mymoney other;
    public Save SaveInformation()
    {
        Save save = new Save();
        GameRecord gameRecord;
        gameRecord.number =other.money;
        gameRecord.result = Result.text;
        save.list.Add(gameRecord);
        return save; 
    }

    private void SaveByBin()
    {
        Save save = SaveInformation();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fileStream = File.Create(Application.dataPath + "/StreamingFile" + "/ byBin.txt");
        bf.Serialize(fileStream, save);
        fileStream.Close();
    }
    public void CunDang()
    {
        SaveByBin();
    }


    public void SetGame(Save save)
    {
        for (int i = 0; i < save.list.Count; i++)
        {
            
        }
    }

    private void LoadByBin()
    {
        if (File.Exists(Application.dataPath + "/StreamingFile" + "/ byBin.txt"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fileStream = File.Open(Application.dataPath + "/StreamingFile" + "/ byBin.txt", FileMode.Open);
            Save save = (Save)bf.Deserialize(fileStream);
            SetGame(save);
            fileStream.Close();
        }
    }

    public void Chakan()
    {
        if (File.Exists(Application.dataPath + "/StreamingFile" + "/ byBin.txt"))
        {
            LoadByBin();
        }
    }
}
