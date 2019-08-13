using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public bool useController;
    Vector3 inputDirection;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //follow the mouse
        if (!useController)
        {
            
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        //with controller
        if(useController)
        {
            inputDirection = Vector3.zero;
            inputDirection.x = Input.GetAxisRaw("LHorizontal");
            inputDirection.y = Input.GetAxisRaw("LVertical");
            if(inputDirection != Vector3.zero)
            { 
            var angle = Mathf.Atan2(inputDirection.x, inputDirection.y) * Mathf.Rad2Deg - 180f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
           
        }

    }
}
