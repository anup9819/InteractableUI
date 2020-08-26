using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabActive;
    public TabButton selectedTab;
    public List<GameObject> ObjectsToSwap;
    public InPanelTransition other;
    public GameObject PanelOtherTab;
    public GameObject CharacterPanelTab;


    public void subscribe(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        tabButtons.Add(button);
    }

    

    public void OnTabExit(TabButton button)
    {
        
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        selectedTab = button;
       
        ResetTabs();
        button.background.sprite = tabActive;
        int index = button.transform.GetSiblingIndex();
        for(int i = 0; i < ObjectsToSwap.Count; i++)
        {
            if (i == index)
            {
                
                ObjectsToSwap[i].SetActive(true);
                LeanTween.scale(PanelOtherTab, new Vector3(1f, 1f, 1f), 0.5f);
                LeanTween.scale(CharacterPanelTab, new Vector3(0f, 0f, 0f), 0.5f);
            }
            else
            {
                ObjectsToSwap[i].SetActive(false);
                LeanTween.scale(PanelOtherTab, new Vector3(0f, 0f, 0f), 0.5f);
                LeanTween.scale(CharacterPanelTab, new Vector3(1f, 1f, 1f), 0.5f);
            }
        }
        
    }

    

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab)
            {
                
                continue;
                
            }
            
            button.background.sprite = tabIdle;
            




        }
    }
}
