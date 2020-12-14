using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wolf :Enemy
{
   
    public  wolf()
    {
        enemyCharacter = CharacterFactory.Instance.JianCha(3);
        nowHp = enemyCharacter.MaxHp;
    }


}
