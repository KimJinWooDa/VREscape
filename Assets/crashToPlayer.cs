using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crashToPlayer : MonoBehaviour
{
    public Transform target;
    public void RushToPlayer()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(target.position);
    }
}
