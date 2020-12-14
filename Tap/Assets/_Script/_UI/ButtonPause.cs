using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class ButtonPause : MonoBehaviour
{
    public Image PauseButton;
    public bool isPause = false;

    public void OnPause()
    {
        if (isPause)
        {
            Time.timeScale = 0f;
            PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("Pause");
            isPause = false;

        }
        else
        {
            Time.timeScale = 1f;
            PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("Start");
            isPause = true;

        }
    }
}
