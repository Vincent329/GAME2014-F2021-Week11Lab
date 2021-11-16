using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public bool jumpButtonPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnJumpButtonDown()
    {
        Debug.Log("Jump Button Pressed");
        jumpButtonPressed = true;
    }
    public void OnJumpButtonUp()
    {
        Debug.Log("Jump Button Released");
        jumpButtonPressed = false;
    }
}
