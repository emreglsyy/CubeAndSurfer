using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    //sola m� sa�a m� gitti�ini tutucaz
    private float horizontalValue;
    //horizontal valuyi d�nd�r�yoruz
    public float HorizontalValue {  get { return horizontalValue; } }


    private void Update()
    {
        HandleHeroHorizontalInput();
    }

    private void HandleHeroHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
