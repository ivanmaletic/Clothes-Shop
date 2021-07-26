using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSceneSwitcher : MonoBehaviour
{
    public GameObject switcher;
    public GameObject interior;
    public void BackToShopping()
    {
        GameObject grid = GameObject.Find("Grid");
        GameObject character = GameObject.Find("Character"); 
        grid.transform.position =new Vector3 (grid.transform.position.x,grid.transform.position.y,0);
        interior.transform.position = new Vector3(interior.transform.position.x, interior.transform.position.y, 0);
        switcher.transform.position = new Vector3(switcher.transform.position.x,switcher.transform.position.y,-100);
        character.GetComponent<BasicMovement>().enabled = true;
        character.GetComponent<Animator>().enabled = true;
        character.transform.position = new Vector3(0, 0, 0);
    }
}
