using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemePanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject RotatingDelay;
    Vector3 Startpos;
    Vector3 EndPos;
    public GameObject CharacterPanelTab;
    public GameObject charactertext;
    public GameObject ExplorerTab;

    public void Start()
    {
        
    }
    public void Themebttn()
    {
        LeanTween.move(Panel.GetComponent<RectTransform>(), new Vector3(0f, -1f, 0f), 1f).setEaseOutBounce();
        LeanTween.move(charactertext.GetComponent<RectTransform>(), new Vector3(0f, 52f, 0f), 1f).setEaseOutBounce().setDelay(0.7f);
        LeanTween.scale(ExplorerTab, new Vector3(1f, 1f, 1f), 0.5f).setDelay(0.2f);
        LeanTween.scale(CharacterPanelTab, new Vector3(1f, 1f, 1f), 0.5f);
        StartCoroutine(BgDelay());
    }
    IEnumerator BgDelay()
    {
        yield return new WaitForSeconds(1.5f);
        RotatingDelay.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        charactertext.SetActive(true);
        

        

    }

    public void Closebttn()
    {
        LeanTween.move(Panel.GetComponent<RectTransform>(), new Vector3(0f, -2275.6f, 0f), 1f).setEaseInOutBack();
        RotatingDelay.SetActive(false);
    }

}
