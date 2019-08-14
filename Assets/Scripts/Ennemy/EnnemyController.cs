using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnnemyController : MonoBehaviour
{
    private Animator ennemyAnimator;
    Vector2 movement;
    Rigidbody2D rb;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ennemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf)
        {
            ennemyAnimator.SetFloat("Horizontal", movement.x);
            ennemyAnimator.SetFloat("Vertical", movement.y);
        }
        
    }

    

}
