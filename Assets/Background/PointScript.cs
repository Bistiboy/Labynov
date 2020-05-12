using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    GameObject point;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.tag == "Dalton")
        //{
        //    point.tag = "";
        //    odeurPied++;
        //}

        //if(collision.tag == "Averell")
        //{
        //    point.tag = "";
        //    odeurBouffe++;
        //    odeurPied++;
        //}

        //if (collision.tag == "Rantanplan")
        //{

        //}
    }
}
