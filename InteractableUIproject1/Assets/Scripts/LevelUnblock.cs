using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LevelUnblock : MonoBehaviour
{
    public string theLevel;
    public GameObject InputField;
    public GameObject TextDisplay;
    private int lvl_int_value;
    public GameObject[] button;
    public GameObject[] text;



    public void StoreLvl()
    {
        
        
        theLevel = InputField.GetComponent<Text>().text;
        TextDisplay.GetComponent<Text>().text = theLevel;
        lvl_int_value = int.Parse(theLevel);
        unlocklogic();


        
        
    }

    
    public void unlocklogic()
    {
        for (int i=0;i<=lvl_int_value;i++)
        {
            
            
            if (i >= 500)
            {
                button[2].SetActive(true);
                text[2].SetActive(false);

            }
            else if (i >= 200)
            {
                button[1].SetActive(true);
                text[1].SetActive(false);

            }
            else if (i >= 50)
            {
                button[0].SetActive(true);
                text[0].SetActive(false);

            }
            else
            {
                Reset();
            }

        }  
        
        
    }

    private void Reset()
    {
        foreach(GameObject gameObject in button)
        {
            gameObject.SetActive(false);
        }
        foreach (GameObject gameObject in text)
        {
            gameObject.SetActive(true);
        }

    }


}
