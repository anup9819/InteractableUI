using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabgroup;
    public Image background;

    
    

    public void OnPointerExit(PointerEventData eventData)//diselection
    {
        tabgroup.OnTabExit(this);


    }
    public void OnPointerClick(PointerEventData eventData)//selection
    {
        tabgroup.OnTabSelected(this);
        
        
    }

    

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        tabgroup.subscribe(this);
    }

    
    
}
