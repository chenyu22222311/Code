using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


using UnityEngine.SceneManagement;

public class Denglu : MonoBehaviour
{
    public InputField inputField, inputField1, ZhuceInputField, ZhuceInputField1;
    public GameObject objProcessBar, load;
    public Text baifenbi;
    public GameObject dl, zhuce;

    public void denglu()
    {

        if (inputField.text == PlayerPrefs.GetString("Name") && inputField1.text == PlayerPrefs.GetString("Password") && ZhuceInputField.text != "" && ZhuceInputField1.text != "")
        {
            load.SetActive(true);
            StartCoroutine(StartLoading(1));
        }
        else
        {
            inputField.text = "";
            inputField1.text = "";
        }
    }
    public void changezhuce()
    {
        dl.SetActive(false);
        zhuce.SetActive(true);
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
