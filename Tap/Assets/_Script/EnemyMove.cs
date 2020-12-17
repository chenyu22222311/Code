using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    private Transform[] positions;
    private int index = 0;
    public float Speed = 5f;

    void Start()
    {
        positions = Waypoints.positions;
    }

    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            Destroy(gameObject);
        }

    }


    void Move()
    {

        if (Vector3.Distance(positions[index].position, transform.position) > 0.05f)
        {
            transform.LookAt(positions[index].position);
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);

        }
        else
        {
            if (index < positions.Length - 1)
                index++;
        }

    }
}
