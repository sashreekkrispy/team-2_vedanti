using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bend : MonoBehaviour
{
    public GameObject disable2;
    public GameObject enable5;
    public destroycounter destroy;
    public bool bender;
    public bool enable = true;
    public GameObject enable4;
    public bendcounter count;
    public GameObject enable7;
    void Update()
    {
     if (destroy.countcheck==true)
        {   
            if (enable==true)
            {
                enable4.SetActive(true);
            }
           
            if (Input.anyKeyDown)
            {
               
                
                    disable2.SetActive(false);
                    enable = false;
                
                
                enable5.SetActive(true);
                bender = true;
            }
        }
     if (count.isbended==true)
        {
            enable5.SetActive (false);
            enable7.SetActive(true);

        }
    }
}
