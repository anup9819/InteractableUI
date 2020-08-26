using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedTabGroup : MonoBehaviour
{
    public List<SelectedTabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabActive;
    public SelectedTabButton selectedTab;
    

    public void subscribe(SelectedTabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<SelectedTabButton>();
        }
        tabButtons.Add(button);
    }



    public void OnTabExit(SelectedTabButton button)
    {

        ResetTabs();
    }

    public void OnTabSelected(SelectedTabButton button)
    {
        selectedTab = button;
        ResetTabs();
        button.background.sprite = tabActive;
        int index = button.transform.GetSiblingIndex();


    }



    public void ResetTabs()
    {
        foreach (SelectedTabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab)
            {

                continue;
            }

            button.background.sprite = tabIdle;



        }
    }
}
