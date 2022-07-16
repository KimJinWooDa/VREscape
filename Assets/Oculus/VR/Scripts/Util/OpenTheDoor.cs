using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for(int i = 0; i < GameManager.Instance.isTrueObjects.Length; i++)
            {
                if (!GameManager.Instance.isTrueObjects[i]) return;


            }
           
            // 무대 문이 열린다
        }
    }
}
