using System.Collections;
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
        textObj = GameObject.Find("Text");
        my = textObj.GetComponent<Mymoney>();
        enemyBuilder = transform.GetComponent<EnemyBuilder>();
    }


    // Update is called once per frame

    void Update()
    {
        if (enemyBuilder.enemy.nowHp<0)
        {
            Destroy(gameObject);
            my.Money(14);
            number++;
        }
    }

   
}