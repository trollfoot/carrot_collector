using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{


    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;

    int score = 0;
    public int winScore;

    public GameObject winText;


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
    vInput = joystick.Vertical * moveSpeed;

    transform.Translate(hInput, vInput, 0);
}


void OnCollisionEnter2D(Collision2D collision) 
{

if(collision.gameObject.tag == "carrot")
    {
        score++;
        Destroy(collision.gameObject);

        if(score >= winScore)
        {
            winText.SetActive(true);
        }
    }

}

}
