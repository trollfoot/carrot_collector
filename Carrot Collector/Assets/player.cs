using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    public FloatingJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void FixedUpdate()
{
    hInput = joystick.Horizontal * moveSpeed;
    vInput = joystick.vertical * moveSpeed;

    transform.Translate(hInput, vInput, 0);
}


}
