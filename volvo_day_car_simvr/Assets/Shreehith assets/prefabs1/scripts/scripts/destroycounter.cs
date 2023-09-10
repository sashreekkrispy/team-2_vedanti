using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    


public class destroycounter : MonoBehaviour
{  
   public static destroycounter instance;
    public TMP_Text destroy;

    public static int currentdestroy ;
    public bool trigger = false;
   public bool countcheck = false;
    
    
     void Awake()
    {
        instance = this;
    }
    private void Start()
    {

        currentdestroy = 0;
        destroy.text =   currentdestroy.ToString() ;

    }
  
    private void Update()
    {
       
        
            if (Input.anyKeyDown)
            {
                trigger = true;
                

                
            }

        
       
        destroy.text = currentdestroy.ToString();
        if (currentdestroy == 4)
        {
            countcheck = true;
        }

    }

}
