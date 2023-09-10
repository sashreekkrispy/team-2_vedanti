using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable : MonoBehaviour
{
    public GameObject disable;
    public GameObject enable1;
    public GameObject enable2;
    public GameObject enable3;
   
    public destroycounter destroy;

    // Update is called once per frame
    void Update()
    {
       if(destroy.trigger==true)
        {
            disable.SetActive(false);
            enable1.SetActive(true);
            enable2.SetActive(true);
            enable3.SetActive(true);
        }
       if (destroy.countcheck==true)
        {
            enable1.SetActive(false); 
            enable2.SetActive(false);
            enable3.SetActive(false);
            


        }
    }
}
