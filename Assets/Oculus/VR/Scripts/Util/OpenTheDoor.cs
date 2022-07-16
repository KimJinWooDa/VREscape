using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    public GameObject door;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            for (int i = 0; i < GameManager.Instance.isTrueObjects.Length; i++)
            {
                if (!GameManager.Instance.isTrueObjects[i]) return;


            }
            // 무대 문이 열린다
            door.GetComponentInChildren<AudioSource>().Pause();
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //페이드 아웃되고 페이드 인 되면서 스테이지 중앙으로
        }
    }
}
