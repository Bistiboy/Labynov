using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdeurPiedScript : MonoBehaviour
{

    int odeur = 400;

    [SerializeField] LayerMask theLayer;
    [SerializeField] GameObject goOdeur;

    //RaycastHit2D haut;
    //RaycastHit2D bas;
    //RaycastHit2D droite;
    //RaycastHit2D gauche;

    //void Update()
    //{
    //    haut = Physics2D.Raycast(transform.position, Vector2.up, 2.64f, theLayer);
    //    bas = Physics2D.Raycast(transform.position, Vector2.down, 2.64f, theLayer);
    //    droite = Physics2D.Raycast(transform.position, Vector2.right, 2.64f, theLayer);
    //    gauche = Physics2D.Raycast(transform.position, Vector2.left, 2.64f, theLayer);

    //    Debug.DrawRay(transform.position, Vector2.up * 2.54f);
    //    Debug.DrawRay(transform.position, Vector2.down * 2.54f);
    //    Debug.DrawRay(transform.position, Vector2.right * 2.54f);
    //    Debug.DrawRay(transform.position, Vector2.left * 2.54f);   
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COUCOU TRIGGER ########" + collision.tag);

        if (collision.tag == "PointDalton" || collision.tag == "PointAverell")
        {
            Debug.Log("COUCOU  ########");
            GameObject op = Instantiate(goOdeur, collision.transform.position, Quaternion.identity);
            odeur--;
        }
    }

    void RependreOdeur(GameObject go, Collider2D collision)
    {
        Debug.Log("########################## ");

        if(collision.tag == "PointDalton" || collision.tag == "PointAverell")
        {
            Debug.Log("COUCOU  ########");
            GameObject op = Instantiate(go, collision.transform.position, Quaternion.identity);
            odeur--;
            collision.tag = "Done";
            Debug.Log("COUCOU FIN ########");
        }

        //if (bas.collider.CompareTag("PointDalton") || bas.collider.CompareTag("PointAverell"))
        //{
        //    Debug.Log("COUCOU  ########");
        //    GameObject op = Instantiate(go, base.collider.transform.position, Quaternion.identity);
        //    odeur--;
        //    Debug.Log("COUCOU FIN ########");
        //}
        //else if (haut.collider.CompareTag("PointDalton") || haut.collider.CompareTag("PointAverell"))
        //{
        //    Debug.Log("COUCOU  HAUT ########" + odeur);
        //    GameObject op2 = Instantiate(go, haut.collider.transform.position, Quaternion.identity);
        //    odeur--;
        //    Debug.Log("COUCOU  HAUT FIN ########" + odeur);
        //}
        //else if (droite.collider.CompareTag("PointDalton") || droite.collider.CompareTag("PointAverell"))
        //{
        //    Debug.Log("COUCOU DROITE ########" + odeur);
        //    GameObject op3 = Instantiate(go, droite.collider.transform.position, Quaternion.identity);
        //    odeur--;
        //    Debug.Log("COUCOU DROITE FIN ########" + odeur);
        //}
        //else if (gauche.collider.CompareTag("PointDalton") || gauche.collider.CompareTag("PointAverell"))
        //{
        //    Debug.Log("COUCOU GAUCHE ########" + odeur);
        //    GameObject op4 = Instantiate(go, gauche.collider.transform.position, Quaternion.identity);
        //    odeur--;
        //    Debug.Log("COUCOU GAUCHE FIN########" + odeur);
        //}

        Debug.Log("###########################!!!!!!!!!!!!!!!!!!!!!!########################## !!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }
}
