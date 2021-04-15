using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twist : MonoBehaviour
{
    private bool drill = false;
    private bool spot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (drill & spot)
        {
            transform.Rotate(new Vector3(0, 0, 2f));
            transform.Translate(new Vector3(0, 0, -.0005f));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Drill")
        {
            Debug.Log("the drill is touching");
            drill = true;
        }
        if (collision.gameObject.tag == "Board")
        {
            spot = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        drill = false;
    }
}

