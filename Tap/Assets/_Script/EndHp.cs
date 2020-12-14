using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class EndHp : MonoBehaviour
{
    public Slider HPslider;
    public GameObject ResultCanvas;
    public Text Result;
    int HP = 100;
    int total;
    public GameObject others;

    void Start()
    {
        total = HP;
    }


    // Update is called once per frame

    void Update()
    {
        if (HP < 100)
        {
            Time.timeScale = 0f;
            ResultCanvas.SetActive(true);
            Result.text = "失败";
        }
        if (EnemyHp.number == others.GetComponent<EnemyBirth>().count * others.GetComponent<EnemyBirth>().counts)
        {
            Time.timeScale = 0f;
            ResultCanvas.SetActive(true);
            Result.text = "胜利！";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            HP -= 20;
            HPslider.value = (float)HP / total;
        }

    }
}
