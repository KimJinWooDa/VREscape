using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isSlot;
    public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;

    public enum itemValue { 진짜, 가짜};
    public itemValue IV;
    public enum itemState { 기계심장, 지푸라기, 용기물약 };
    public itemState IS;

    public void CheckItemValue()
    {
        if(IV == itemValue.가짜)
        {
            switch (IS)
            {
                case itemState.기계심장:
                    GameManager.instance.isFalseObjects[0] = true;
                    break;
                case itemState.지푸라기:
                    GameManager.instance.isFalseObjects[1] = true;
                    break;
                case itemState.용기물약:
                    GameManager.instance.isFalseObjects[2] = true;
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (IS)
            {
                case itemState.기계심장:
                    GameManager.instance.isTrueObjects[0] = true;
                    break;
                case itemState.지푸라기:
                    GameManager.instance.isTrueObjects[1] = true;
                    break;
                case itemState.용기물약:
                    GameManager.instance.isTrueObjects[2] = true;
                    break;
                default:
                    break;
            }
        }
    }
}
