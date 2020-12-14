using System.Collections;

using System.Collections.Generic;

using UnityEngine;

//建塔和拆塔
public class ModelBirth : MonoBehaviour
{
    public GameObject textObj;
    public static GameObject Model;
    Mymoney my;
    public GameObject game;
   

    // Start is called before the first frame update

    void Start()
    {
        my = textObj.GetComponent<Mymoney>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits;
            hits = Physics.RaycastAll(ray);
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.gameObject.name == "底座")
                {
                    if (hit.transform.childCount == 0)
                    {

                        new State01().WFvfds(game, my, 1);
                        if (Mymoney.isBuildmodel)
                        {
                            Model = Instantiate(Resources.Load(MainController.modelname, typeof(GameObject)) as GameObject);
                            Model.transform.parent = hit.transform;
                            Model.transform.localPosition = Vector3.zero;
                        }

                    }
                    else if (hit.transform.childCount != 0)
                    {
                        new State01().WFvfds(hit.transform.GetChild(0).gameObject, my, 3);
                        Destroy(hit.transform.GetChild(0).gameObject);
                    }
                }
            }
        }
    }
}
   
 
   

