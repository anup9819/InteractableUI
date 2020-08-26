using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPanelTransition : MonoBehaviour
{
  public GameObject panelfirst;
  public GameObject panelsecond;

    public void PanelFirstFadeIn()
    {
        LeanTween.scale(panelfirst, new Vector3(0f, 0f, 0f), 0.1f);
        LeanTween.scale(panelsecond, new Vector3(1f, 1f, 1f), 0.1f);
    }

    public void PanelSecondFadeIn()
    {
        LeanTween.scale(panelsecond, new Vector3(0f, 0f, 0f), 0.1f);
        LeanTween.scale(panelfirst, new Vector3(1f, 1f, 1f), 0.1f);
        
    }

    public void PanelIdle()
    {
        LeanTween.scale(panelfirst, new Vector3(1f, 1f, 1f), 0.1f);
        LeanTween.scale(panelsecond, new Vector3(1f, 1f, 1f), 0.1f);
    }


}
