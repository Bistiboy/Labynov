using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RantanplanScript : MonoBehaviour
{

    [SerializeField] int obeissance;
    [SerializeField] int vies;
    [SerializeField] int faim;
    [SerializeField] int vieMax;
    [SerializeField] bool estIntelligent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void seBlesse(){
        vies -= 1;
        faim += obeissance / vieMax;
        obeissance -= faim / vieMax;
    }

    public bool estMort(){
        // Si vie = 0 return true, sinon return false
        if(vies == 0){
            return true;
        } else {
            return false;
        }
    }
}
