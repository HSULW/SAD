using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVisibility : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    private bool IsButtonActive = false;

    public void ButtonShowOrNot(){
        IsButtonActive = !IsButtonActive;
        Button1.SetActive(IsButtonActive);
        Button2.SetActive(IsButtonActive);
        Button3.SetActive(IsButtonActive);
    }
}
