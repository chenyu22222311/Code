using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public void Replay(int i)
    {
        SceneManager.LoadScene(i);
        EnemyHp.number = 0;
    }
}
