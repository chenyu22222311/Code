using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fox :Enemy
{
    public fox()
    {
        enemyCharacter = CharacterFactory.Instance.JianCha(1);
    }
}
