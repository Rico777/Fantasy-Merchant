using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 
public class Enable : MonoBehaviour , IPointerDownHandler 
{
    public Transform itemsParent; 
    public Image redButton;
    public Image inventoryButton;
    public Text inventoryText; 
    int i = 0;
    Image[] slots; 

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        redButton.enabled = false;
        inventoryButton.enabled = true;
        inventoryText.enabled = false;
        slots = itemsParent.GetComponentsInChildren<Image>();

        while (slots[i])
        {
            slots[i].enabled = false;
            i++;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        redButton.enabled = !redButton.enabled;
        inventoryButton.enabled = !inventoryButton.enabled;
        inventoryText.enabled = !inventoryText.enabled;
        i = 0;

        while (slots[i])
        {
            slots[i].enabled = !slots[i].enabled;
            i++;
        }
    }
}
