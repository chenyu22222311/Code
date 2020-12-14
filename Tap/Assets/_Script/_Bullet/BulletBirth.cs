using UnityEngine;

public class BulletBirth : MonoBehaviour
{
    public string bull;
    bool isbool = false;
    void Start()
    {
        InvokeRepeating("MyBull", 1, 1);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            isbool = true;
        }
    }
    public void MyBull()
    {
        if (isbool)
        {
            GameObject Bull = Instantiate(Resources.Load(bull, typeof(GameObject)) as GameObject);
            Bull.transform.parent = transform;
            Bull.transform.localPosition = new Vector3(0, 5f, 0);
            isbool = false;

        }

    }

}
