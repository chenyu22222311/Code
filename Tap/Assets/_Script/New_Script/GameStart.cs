using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    public GameObject objProcessBar, load;
    public Text baifenbi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void denglu()
    {
        load.SetActive(true);
        StartCoroutine(StartLoading(0));

    }
    public IEnumerator StartLoading(int str)
    {
        float i = 0;
        AsyncOperation acOp = SceneManager.LoadSceneAsync(str);
        acOp.allowSceneActivation = false;
        while (i <= 100)
        {
            i++;
            objProcessBar.GetComponent<Slider>().value = i / 100;
            yield return new WaitForEndOfFrame();
            baifenbi.text = "" + i + "%";
        }
        acOp.allowSceneActivation = true;

    }
}
