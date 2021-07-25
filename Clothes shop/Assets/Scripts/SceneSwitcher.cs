using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject[] sides;
    public GameObject switcher;
    public void OnTriggerEnter2D(Collider2D other)
    {
        GameObject interiorObcjets = GameObject.Find("ItemsInterior");
        GameObject grid = GameObject.Find("Grid");
        GameObject character = GameObject.Find("Character");
        interiorObcjets.SetActive(false);
        grid.SetActive(false);
        character.GetComponent<BasicMovement>().enabled = false;
        character.GetComponent<Animator>().enabled = false;
        SideActivator(2);
        switcher.SetActive(true);
    }
    public void BackToShop()
    {
    }
    private void SideActivator(int j)
    {
        for (int i = 0; i < 4; i++) { sides[i].SetActive(false); }
        sides[j].SetActive(true);
    }

}
