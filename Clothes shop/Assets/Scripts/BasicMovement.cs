using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 4f;
    public Animator animator;
    Vector2 movement=new Vector2(0,0);
    public Rigidbody2D rb;
    public GameObject[] sides;
    
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (movement.x >= 0 && movement.y >= 0)
        {
            if (movement.x > movement.y)
            {
                SideActivator(1);
            }
            else
            {
                SideActivator(3);
            }
        }
        if (movement.x<=0&&movement.y>=0) 
        {
            if (Mathf.Abs(movement.x) > movement.y) 
            {
                SideActivator(0);
            }
            else
            {
                SideActivator(3);
            }
        }
        if (movement.x >= 0 && movement.y <= 0)
        {
            if (movement.x > Mathf.Abs(movement.y))
            {
                SideActivator(1);
            }
            else
            {
                SideActivator(2);
            }
        }
        if (movement.x <= 0 && movement.y <= 0)
        {
            if (Mathf.Abs(movement.x) > Mathf.Abs( movement.y))
            {
                SideActivator(0);
            }
            else
            {
                SideActivator(2);
            }
        }
    }
    private void SideActivator(int j)
    {
        for (int i = 0; i < 4; i++) { sides[i].SetActive(false); }
        sides[j].SetActive(true);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}
