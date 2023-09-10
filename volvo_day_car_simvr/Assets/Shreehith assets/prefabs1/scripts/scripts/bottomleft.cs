using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomleft : MonoBehaviour
{
    //public Animator object1animator;
    public GameObject playerobject;

    //public bool animator1 = false;
    public Animator animation;
    //public destroycounter counter;
    void Update()
    {   
       
        //if (counter.trigger == true )
        //{
            
                        if (playerobject.GetComponent<Animator>().enabled==true)
                        {
                            //object1animator.SetTrigger("DestroyTrigger");
          // playerobject.GetComponent<Animator>().Play("bottomleft");
            
                            StartCoroutine(waitforseconds());
                            //animator1 = true;
                        }

                    
                

           // }
     }
        
        IEnumerator waitforseconds()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
            //destroycounter.currentdestroy++;
            Debug.Log(destroycounter.currentdestroy);
        }
 }

