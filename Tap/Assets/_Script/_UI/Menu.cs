using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject SoundCanvas;
    public bool isShow = false;
    public AudioSource asound;
    public Slider sd;
    // Start is called before the first frame update

    public void OnMenu()
    {
        if (!isShow)
        {
            SoundCanvas.SetActive(false);
            isShow = true;
        }
        else
        {
            SoundCanvas.SetActive(true);
            Sound();
            isShow = false;
        }

    }


    public void Sound()
    {
        asound.volume = sd.value;
    }
}