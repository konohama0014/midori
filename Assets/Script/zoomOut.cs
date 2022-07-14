using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomOut : MonoBehaviour
{
    public GameObject mainCamObj;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void touchZoomOut()
    {
        mainCamObj.transform.position = new Vector3(0, 0, -100);
    }

    public void touchZoomIn()
    {
        mainCamObj.transform.position = new Vector3(0, 0, -10);
    }

}
