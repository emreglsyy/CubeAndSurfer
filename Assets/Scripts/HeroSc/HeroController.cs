using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    //sola mý saða mý gittiðini tutucaz
    private float horizontalValue;
    //horizontal valuyi döndürüyoruz
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
