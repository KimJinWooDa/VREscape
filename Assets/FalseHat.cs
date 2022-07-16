using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseHat : MonoBehaviour
{
    bool isRaise;
    public GameObject hahahaha;

    private void OnTriggerEnter(Collider other)
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            hahahaha.GetComponent<crashToPlayer>().RushToPlayer();
            isRaise = false;
        }
    }
}
