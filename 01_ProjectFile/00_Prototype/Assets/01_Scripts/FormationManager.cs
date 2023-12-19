using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FormationManager : MonoBehaviour
{
    public GameObject selectUI;
    [SerializeField]
    GameObject selectSlot;

    public void EmptySlotClicked()
    {
        selectSlot = EventSystem.current.currentSelectedGameObject;
        switch (selectSlot.name)
        {
            case "CharSlotA" :
                selectUI.SetActive(true);
                break;
            case "CharSlotB":
                selectUI.SetActive(true);
                break;
            case "CharSlotC":
                selectUI.SetActive(true);
                break;
        }
    }
}
