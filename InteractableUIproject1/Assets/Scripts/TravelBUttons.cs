using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelBUttons : MonoBehaviour
{
    public GameObject [] CharacterTabs;

private int _index;

public void PreviousModel()
{
        // Hide current model
        CharacterTabs[_index].SetActive(false);

    _index--;
    if(_index < 0)
    {
        _index = CharacterTabs.Length -1;
    }

        // Show previous model
        CharacterTabs[_index].SetActive(true);
}

public void NextModel()
{
        // Hide current model
        CharacterTabs[_index].SetActive(false);

    _index++;

    if(_index > CharacterTabs.Length -1)
    {
        _index = 0;
    }

        // Show next model
        CharacterTabs[_index].SetActive(true);
}
}
