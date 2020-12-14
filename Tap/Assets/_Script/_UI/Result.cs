using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    public GameObject other;
    public Text EnemyNumber;
    public Text MoneyNumber;

    void Update()
    {
        EnemyNumber.text = "击杀怪物的数量" + EnemyHp.number;
        MoneyNumber.text = "金币的的剩余量" + other.GetComponent<Mymoney>().money;
    }
}
