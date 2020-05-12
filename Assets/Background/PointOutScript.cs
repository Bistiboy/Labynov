using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOutScript : MonoBehaviour
{
    [SerializeField] GameObject goOdeurPied;
    [SerializeField] GameObject goOdeurBouffe;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Dalton")
        {
            collision.GetComponent<CapsuleCollider2D>().enabled = false;
            GameObject op = Instantiate(goOdeurPied, collision.transform.position, Quaternion.identity);  
        }

        if(collision.tag == "Averell")
        {
            collision.GetComponent<CapsuleCollider2D>().enabled = false;
            GameObject op = Instantiate(goOdeurPied, collision.transform.position, Quaternion.identity);
            GameObject ob = Instantiate(goOdeurBouffe, collision.transform.position, Quaternion.identity);     
        }

    }
}
