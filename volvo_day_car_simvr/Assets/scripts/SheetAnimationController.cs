using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetAnimationController : MonoBehaviour
{
    
    void Update()
    {
        StartCoroutine(DestroyObject());
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
