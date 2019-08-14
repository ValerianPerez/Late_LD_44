using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class PlayerController : MonoBehaviour
{
    private int sanity;
    public int damage;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Light2D light;
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
            Destroy(other.gameObject);

            sanity = sanity - damage;
            if(sanity <= 90)
            {
                playerAnimator.SetBool("alive", false);
                light.gameObject.SetActive(false);
            }

            light.pointLightOuterAngle += 20;
            light.pointLightInnerAngle += 15;
        }
    }
}
