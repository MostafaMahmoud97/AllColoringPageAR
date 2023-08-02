using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSystemsScript : MonoBehaviour
{

    bool checkClickMouse = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            checkClickMouse = true;
        }

        if(checkClickMouse )
        {
            float mouseMoveX = Input.GetAxis("Mouse X") * -1;
            float mouseMoveY = Input.GetAxis("Mouse Y") * -1;

            this.transform.Rotate(new Vector3(mouseMoveY * 20f, mouseMoveX * 20f , 0f));

        }

        if (Input.GetMouseButtonUp(0))
        {
            checkClickMouse = false;
        }
    }
}
