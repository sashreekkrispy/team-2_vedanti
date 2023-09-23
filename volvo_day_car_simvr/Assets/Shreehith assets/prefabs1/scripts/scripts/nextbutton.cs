using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextbutton : MonoBehaviour
{
    public GameObject intro;
    public GameObject button;


    public int nextcounter=0;
    public void okay()
    {
        nextcounter++;
    }
     void FixedUpdate()
    {
       if (nextcounter == 1 )
        {
            intro.SetActive( false );
            button.SetActive( true );
        }
    }
}
