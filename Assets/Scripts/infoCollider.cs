using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoCollider : MonoBehaviour
{
    public GameObject PanelInfo;
    public GameObject infoImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PanelInfo.SetActive(true);
            infoImage.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PanelInfo.SetActive(false);
            infoImage.SetActive(true);
        }
    }
}
