using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public bool[] isTrueObjects;
    public bool[] isFalseObjects;

    public GameObject[] lights;
    public GameObject destroy;
    void Awake()
    {
        if (null == instance)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public void OffLights()
    {
        for(int i =0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }
    }

    private void Update()
    {
            for(int i = 0; i < isTrueObjects.Length; i++)
        {
            if (!isTrueObjects[i]) return;
        }
        if (destroy != null ) Destroy(destroy);
    }
}
