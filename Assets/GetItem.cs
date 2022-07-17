using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
            {
                Item item = other.GetComponent<Item>();
                Item.itemValue it = item.GetComponent<Item>().IV;
                item.CheckItemValue(it);
            }
        }
    }
}
