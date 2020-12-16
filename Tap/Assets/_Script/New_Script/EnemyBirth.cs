using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class EnemyBirth : MonoBehaviour
{
    public GameObject[] Enemies;
    public int count;//每波多少怪
    public int counts;//有多少波
    public float countTime;
    public float countsTime;
    void Start()
    {
        StartCoroutine(TheEnemy());
    }


    public IEnumerator TheEnemy()
    {
        for (int i = 0; i < counts; i++)
        {
            for (int j = 0; j < count; j++)
            {
                GameObject Enemy = Instantiate(Enemies[Random.Range(0, Enemies.Length)]);   

                Enemy.transform.parent = transform;
                Enemy.transform.localPosition = Vector3.zero;
                yield return new WaitForSeconds(countTime);
            }
            yield return new WaitForSeconds(countsTime);
        }
        StopCoroutine(TheEnemy());
    }





}
