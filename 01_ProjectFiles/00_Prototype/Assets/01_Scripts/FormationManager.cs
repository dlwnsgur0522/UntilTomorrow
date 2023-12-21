using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FormationManager : MonoBehaviour
{
    public GameObject selectUI;
    string[] formationSave = new string[3];
    [SerializeField]
    GameObject selectSlot;
    Image btnImage;
    DataManager dataManager;

    private void Start()
    {
        switch (dataManager.formation[0])
        {
            case "A" :
                selectSlot.GetComponent<Image>().sprite = Resources.Load<Sprite>("Portrait/A");
                break;
        }
    }

    public void EmptySlotClicked()
    {
        selectSlot = EventSystem.current.currentSelectedGameObject;
        switch (selectSlot.name)
        {
            case "CharSlotA" :
                dataManager.formation[0] = "A";
                selectSlot.GetComponent<Image>().sprite = Resources.Load<Sprite>("Portrait/A");
                //selectUI.SetActive(true);
                break;
            case "CharSlotB":
                btnImage = selectSlot.GetComponent<Image>();
                selectUI.SetActive(true);
                break;
            case "CharSlotC":
                btnImage = selectSlot.GetComponent<Image>();
                selectUI.SetActive(true);
                break;
        }
    }
}
