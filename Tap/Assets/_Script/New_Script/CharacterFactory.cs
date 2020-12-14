using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory 
{
    private static CharacterFactory instance;
    private  Dictionary<int, EnemyCharacter> dic = new Dictionary<int, EnemyCharacter>();
    public  CharacterFactory()
    {
        dic.Add(1, new EnemyCharacter("Enemy_01", 100, 8));
        dic.Add(2, new EnemyCharacter("Enemy_02", 80, 5));
        dic.Add(3, new EnemyCharacter("Enemy_03", 60, 3));
    }

    public static CharacterFactory Instance
    {
        get
        {
            if (instance == null)
            {
                instance =new CharacterFactory ();
            }
            return instance;

        }

    }

    public  EnemyCharacter JianCha(int ID)
    {   
        if (dic.ContainsKey(ID))
        {
            return dic[ID];
        }
        return null;
    }
}
