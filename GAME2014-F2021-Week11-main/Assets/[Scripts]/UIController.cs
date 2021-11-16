using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIController : MonoBehaviour
{
    [Header("On Screen Controls")]
    public GameObject onScreenControls;

    [Header("Button Events")]
    public static bool jumpButtonPressed;
    private void Start()
    {
        switch (Application.platform)
        {
            case (RuntimePlatform.Android):
            case (RuntimePlatform.IPhonePlayer):
            case (RuntimePlatform.WindowsEditor):
                onScreenControls.SetActive(true);
                break;
            default:
                onScreenControls.SetActive(false);
                break;
        }
    }

    private void Update()
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
