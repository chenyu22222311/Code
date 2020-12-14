using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBuilder : MonoBehaviour
{
    public Enemy enemy;
    public Slider blood;


    void Start()
   {
       if(transform.gameObject.name== "Enemy_01(Clone)")
       {
            enemy = new fox();
        }else if (transform.gameObject.name == "Enemy_02(Clone)")
        {
            enemy = new qingwa();
        }
        else if (transform.gameObject.name == "Enemy_03(Clone)")
        {
             enemy = new wolf();
         }

        enemy.nowHp = enemy.enemyCharacter.MaxHp;
        enemy.monsterBloodBar = blood;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bull")
        {
            enemy.nowHp -= other.transform.gameObject.GetComponent<BullMove>().damage;
        }
    }

   
    void Update()
    {
        BloodManager.Instance.SetBlood(enemy);
    }


   
}

