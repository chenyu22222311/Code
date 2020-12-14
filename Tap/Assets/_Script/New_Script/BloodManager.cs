using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodManager 
{
    private static BloodManager instance;

    public static BloodManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new BloodManager();
            }
            return instance;
        }
    }

    public void  SetBlood(Enemy enemy)
    {
        enemy.monsterBloodBar.value=enemy.nowHp / enemy.enemyCharacter.MaxHp;
    }
}
