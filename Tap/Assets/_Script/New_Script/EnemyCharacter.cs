using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter
{
    private string name;
    private float maxHp;
    private float speed;

    public EnemyCharacter(string name,float maxHp,float speed)
    {
        this.MaxHp = maxHp;
        this.Name = name;
        this.speed = speed;
    }

    public string Name { get => name; set => name = value; }
    public float MaxHp { get => maxHp; set => maxHp = value; }
    public float Speed { get => speed; set => speed = value; }
}
