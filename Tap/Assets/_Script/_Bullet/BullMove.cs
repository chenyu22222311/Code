using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class BullMove : MonoBehaviour
{
    public int damage;
   
    public float Speed = 10f;
    GameObject Enemy;
    int n = 0;
    Transform MyEnemy;
    void Start()
    {
        float min = 10000;
        Enemy = GameObject.Find("Enemy");
        for (int i = 0; i < Enemy.transform.childCount; i++)
        {
            float[] Distance = new float[Enemy.transform.childCount];
            Distance[i] = Vector3.Distance(Enemy.transform.GetChild(i).position, transform.position);
            if (Distance[i] < min)
            {
                min = Distance[i];
                n = i;
            }
            MyEnemy = Enemy.transform.GetChild(n);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.LookAt(MyEnemy);
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;
        Destroy(gameObject, 3);
    }
}


