using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesSelectionScript : MonoBehaviour
{
    [Header ("Sprites To Change")]
    public List<SpriteRenderer> bodyPart=new List<SpriteRenderer>();

    [Header("Sprites To Cycle Trough")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count) { currentOption = 0; }
        foreach(SpriteRenderer bodypart in bodyPart)
            bodypart.sprite = options[currentOption];
    }
    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <0) {currentOption= options.Count - 1; }
        foreach (SpriteRenderer bodypart in bodyPart)
            bodypart.sprite = options[currentOption];
    }
}
