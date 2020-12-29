using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public static List<GameRecord> list ;
 
    void Awake()
    {
        list = new List<GameRecord>();
        DontDestroyOnLoad(transform.gameObject);
    }
}
