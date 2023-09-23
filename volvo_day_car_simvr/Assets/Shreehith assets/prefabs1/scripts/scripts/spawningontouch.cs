using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningontouch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves an object with the "spawn" tag
        if (collision.gameObject.CompareTag("patch"))
        {
            // Enable the MeshRenderer component on the object with the "spawn" tag
            MeshRenderer renderer = collision.gameObject.GetComponent<MeshRenderer>();
            if (renderer != null)
            {
                renderer.enabled = true;
            }
        }
    }
}
