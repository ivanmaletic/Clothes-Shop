using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject[] sides;
    public GameObject switcher;
    public GameObject interior;


    public void OnTriggerEnter2D(Collider2D other)
    {
        GameObject grid = GameObject.Find("Grid");
        GameObject character = GameObject.Find("Character");
        character.GetComponent<BasicMovement>().enabled = false;
        character.GetComponent<Animator>().enabled = false;
        grid.transform.position = new Vector3(grid.transform.position.x, grid.transform.position.y, -100);
        interior.transform.position = new Vector3(interior.transform.position.x, interior.transform.position.y, -100);
        switcher.transform.position = new Vector3(switcher.transform.position.x, switcher.transform.position.y, 0);
        SideActivator(2);
        switcher.SetActive(true);
        character.transform.position = new Vector3(13, 0, 0);
    }

    private void SideActivator(int j)
    {
        for (int i = 0; i < 4; i++) { sides[i].SetActive(false); }
        sides[j].SetActive(true);
    }

}
