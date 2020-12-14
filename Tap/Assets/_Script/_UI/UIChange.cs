using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class UIChange : MonoBehaviour

{
    public GameObject game;
    void Start()
    {
        game = GameObject.Find("TagChange");
    }
    public void ChangeModel(string name)
    {
        game.tag = name;
        MainController.modelname = name;
       // MainController.isbool = true;

    }


}
