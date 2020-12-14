using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qingwa :Enemy
{
    public qingwa()
    {
        enemyCharacter = CharacterFactory.Instance.JianCha(3);
    }
}
