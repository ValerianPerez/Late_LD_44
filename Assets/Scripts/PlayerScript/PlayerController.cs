using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int sanity;
    public int damage;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public new GameObject light;
    Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        sanity = 100;
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sanity>0)
        { 
            movement = Vector2.zero;
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            UpdateAnimationAndMove();
        }
        else
        {
            movement = Vector2.zero;
        }
    }

    void MoveCharacter()
    {
        //Movement
        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime);
    }

    void UpdateAnimationAndMove()
    {
        if (movement != Vector2.zero)
        {
            MoveCharacter();
            playerAnimator.SetFloat("Horizontal", movement.x);
            playerAnimator.SetFloat("Vertical", movement.y);
            playerAnimator.SetBool("moving", true);
        }
        else
        {
            playerAnimator.SetBool("moving", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("interactableObject"))
        {
            other.gameObject.SetActive(false);
            sanity = sanity - damage;
            if(sanity <= 0)
            {
                playerAnimator.SetBool("alive", false);
                light.SetActive(false);
            }
        }
    }
}
