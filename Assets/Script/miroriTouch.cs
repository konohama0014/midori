using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miroriTouch : MonoBehaviour
{
    //public GameObject kakusyuku;
    //public GameObject suzirimoziri;
    public GameObject midori;
    private Rigidbody2D rbody2D;
    Vector3 thisPos;

    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addMidori()
    {
        thisPos = this.transform.position;
        //Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(midori, new Vector3(0,0,0) , Quaternion.identity);

    }

}
