using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isSlot;
    public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;

    public enum itemValue { ��¥, ��¥};
    public itemValue IV;
    public enum itemState { ������, ��Ǫ���, ��⹰�� };
    public itemState IS;

    public void CheckItemValue()
    {
        if(IV == itemValue.��¥)
        {
            switch (IS)
            {
                case itemState.������:
                    GameManager.instance.isFalseObjects[0] = true;
                    break;
                case itemState.��Ǫ���:
                    GameManager.instance.isFalseObjects[1] = true;
                    break;
                case itemState.��⹰��:
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
                case itemState.������:
                    GameManager.instance.isTrueObjects[0] = true;
                    break;
                case itemState.��Ǫ���:
                    GameManager.instance.isTrueObjects[1] = true;
                    break;
                case itemState.��⹰��:
                    GameManager.instance.isTrueObjects[2] = true;
                    break;
                default:
                    break;
            }
        }
    }
}
