using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public struct GameRecord
{
   public  int  number;
   public  string  result;
}

[Serializable]
public class Save 
{
    public List<GameRecord> list = new List<GameRecord>();
}
