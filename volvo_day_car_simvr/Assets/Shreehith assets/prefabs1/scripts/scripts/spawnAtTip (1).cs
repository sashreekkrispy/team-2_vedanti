using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class spawnAtTip : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject parentPrefab;
    private Vector3 banKai;

    GameObject snapparent;
    Vector3 offset;

    private bool triggerPressed = false; // Track the trigger button state

    void Start()
    {
        // Initialize Input System for VR
        InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand); // Change XRNode to LeftHand if needed
        device.TryGetFeatureValue(CommonUsages.triggerButton, out triggerPressed);
    }

    void Update()
    {
        // Check if the trigger button is pressed
        if (triggerPressed)
        {
            banKai = this.gameObject.transform.GetChild(1).transform.position;
            Instantiate(prefabToSpawn, banKai, Quaternion.identity, parentPrefab.transform);
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "plate" || collider.gameObject.tag == "cuts5" || collider.gameObject.tag == "cuts6" || collider.gameObject.tag == "cuts7" || collider.gameObject.tag == "cuts8")
        {
            snapparent = collider.gameObject;
            offset = transform.position - snapparent.transform.position;
        }

        if (collider.gameObject.tag == "Test")
        {
            if (triggerPressed)
            {
                Instantiate(prefabToSpawn, banKai, Quaternion.identity);
                Debug.Log("lol");
            }
        }
    }
}