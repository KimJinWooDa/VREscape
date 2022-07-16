using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryVR : MonoBehaviour
{
    public GameObject inventory;
    public GameObject anchor;
    bool UIActive;
    void Start()
    {
        inventory.SetActive(false);
        UIActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            UIActive = !UIActive;
            inventory.SetActive(UIActive);

            if (UIActive)
            {
                inventory.transform.position = anchor.transform.position;
                inventory.transform.eulerAngles = new Vector3(anchor.transform.eulerAngles.x + 15, anchor.transform.eulerAngles.y, 0);

            }
        }
    }
}
