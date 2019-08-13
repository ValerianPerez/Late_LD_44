using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public bool useController;
    Animator playerAnimator;
    private int countItem;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            movement = Vector2.zero;
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            UpdateAnimationAndMove();
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("interactableObject"))
        {
            other.gameObject.SetActive(false);
            countItem = countItem + 1;
        }
    }
}
