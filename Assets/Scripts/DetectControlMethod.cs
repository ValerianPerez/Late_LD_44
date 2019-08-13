using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectControlMethod : MonoBehaviour
{
    public LightController theLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detect Mouse Input
        if(Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2) || Input.anyKeyDown)
        {
            theLight.useController = false;
        }

        //Detect Controller
        if(Input.GetAxisRaw("LHorizontal") != 0.0f || Input.GetAxisRaw("LVertical") !=0.0f)
        {
            theLight.useController = true;
        }
    }
}
