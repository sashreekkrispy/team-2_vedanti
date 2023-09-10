using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class bendcounter : MonoBehaviour
{
    public static bendcounter instance;
    public TMP_Text bend;

    public static int currentbend;

    public bend bended;
    public bool isbended = false;

    
    void Awake()
    {
        instance = this;
    }
    private void Start()
    {

        currentbend = 0;
        bend.text = currentbend.ToString();

    }

    private void Update()
    {
        if(bended.bender==true)
        {
            bend.text = currentbend.ToString();
        }
       

        if (currentbend == 4)
        {
            isbended= true;
        }
       



        



       
    }


}
