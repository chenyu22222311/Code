﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    private GameObject textObj;
    Mymoney my;
    EnemyBuilder enemyBuilder;
    public static int number = 0;
 
    // Start is called before the first frame update

    void Start()
    {
        textObj = GameObject.Find("Jinbi");
        my = textObj.GetComponent<Mymoney>();
        enemyBuilder = transform.GetComponent<EnemyBuilder>();
    }


    // Update is called once per frame

    void Update()
    {
        Debug.Log(0);
        if (enemyBuilder.enemy.nowHp<0)
        {
            Debug.Log(enemyBuilder.enemy.nowHp);
            Destroy(gameObject);
            number++;
            my.Money(14);
            
        }
    }

   
}