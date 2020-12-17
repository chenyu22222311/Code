using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
  //  public static ExampleClass instance;
    public static List<GameRecord> list ;
      

    //static ExampleClass()
    //{
    //    Debug.Log(0);
    //    GameObject go = new GameObject("Globa");
    //    Debug.Log(1);
    //    DontDestroyOnLoad(go);
    //    Debug.Log(2);
    //    instance = go.AddComponent<ExampleClass>();
    //}
    void Awake()
    {
        list = new List<GameRecord>();
        DontDestroyOnLoad(transform.gameObject);
    }
}
