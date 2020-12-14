using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Zhuce : MonoBehaviour

{
   
public  InputField ZhuceInputField,ZhuceInputField1,ZhuceInputField2; 
public GameObject dl,zhuce,objProcessBar;
public Text baifenbi; 
// Start is called before the first frame update
    
void Start()
    
{
        
   
 }

    
// Update is called once per frame
    
void Update()
    
{
        
    
}
public void zhuceyonghu()
{

if (ZhuceInputField.text != "" && ZhuceInputField1.text != "" && ZhuceInputField2.text != ""
             && ZhuceInputField1.text == ZhuceInputField2.text) {
             PlayerPrefs.SetString ( "Name",ZhuceInputField.text);
             PlayerPrefs.SetString ( "Password",ZhuceInputField1.text);

      dl.SetActive(true);
      zhuce.SetActive(false);
}
}




}
