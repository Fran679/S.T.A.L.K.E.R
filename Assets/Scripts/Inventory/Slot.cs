using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{

    public bool hovered;
    private bool used;

    private GameObject item;
    private Texture itemIcon;


     void Start()
    {
        hovered = false;
    }

     void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hovered = false;
    }
}
