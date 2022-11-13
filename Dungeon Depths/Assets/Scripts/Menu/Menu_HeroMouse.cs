using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_HeroMouse : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer rend;

    // Sets the animator and sprite renderer
    void Start()
    {
        anim = GetComponent<Animator>();
        if(anim != null) {
            rend = GetComponent<SpriteRenderer>();
        }
    }

    // Flips the sprite to always face the direction the mouse is in.
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(mousePos.x < gameObject.transform.position.x) {
            rend.flipX = true;
            anim.SetBool("Mouse Left", true);
        }
        if (mousePos.x > gameObject.transform.position.x) {
            rend.flipX = false;
            anim.SetBool("Mouse Left", false);
        }
    }

    // Sets the animator bool Mouse On to true when the mouse is over the sprite
    private void OnMouseEnter()
    {
        anim.SetBool("Mouse On", true);
    }
    // Sets the animator bool Mouse On to false when the mouse leaves the sprite
    private void OnMouseExit()
    {
        anim.SetBool("Mouse On", false);
    }
}
