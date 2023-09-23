using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class spawnAtTip : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject parentPrefab;
    private Vector3 banKai;

    private GameObject snapparent;
    private Vector3 offset;

    private bool triggerPressed = false; // Track the trigger button state

    void Update()
    {
        // Initialize Input System for VR and check if the trigger button is pressed
        InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand); // Change XRNode to LeftHand if needed
        device.TryGetFeatureValue(CommonUsages.triggerButton, out triggerPressed);

        if (triggerPressed)
        {
            Transform child = this.gameObject.transform.GetChild(1);
            if (child != null)
            {
                banKai = child.position;
                Instantiate(prefabToSpawn, banKai, Quaternion.identity, parentPrefab.transform);
            }
            else
            {
                Debug.LogWarning("Child object at index 1 does not exist.");
            }
        }
    }

    void OnTriggerStay(Collider collider)
    {
        string tag = collider.gameObject.tag;
        if (tag == "plate" || tag == "cuts5" || tag == "cuts6" || tag == "cuts7" || tag == "cuts8")
        {
            snapparent = collider.gameObject;
            offset = transform.position - snapparent.transform.position;
        }

        if (tag == "Test" && triggerPressed)
        {
            Instantiate(prefabToSpawn, banKai, Quaternion.identity);
            Debug.Log("lol");
        }
    }
}
