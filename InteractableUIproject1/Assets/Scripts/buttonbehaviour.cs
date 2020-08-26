using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonbehaviour : MonoBehaviour
{
    public GameObject CharButton;
    public GameObject OtherButton;
    
    public void Start()
    {
        LeanTween.scale(CharButton, new Vector3(1.1f, 1.1f, 0), 0.5f);
    }
    public void charbutton()
    {
        LeanTween.scale(CharButton, new Vector3(1.1f, 1.1f, 0), 0.5f);
        LeanTween.scale(OtherButton, new Vector3(1f, 1f, 0), 0.5f);
    }

    public void otherbutton()
    {
        LeanTween.scale(CharButton, new Vector3(1f, 1f, 0), 0.5f);
        LeanTween.scale(OtherButton, new Vector3(1.1f, 1.1f, 0), 0.5f);

    }
}
