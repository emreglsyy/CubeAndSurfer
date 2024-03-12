using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroController heroInputController;

    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;

    private void FixedUpdate()
    {
        SetHeroForwardMovement();
        SetHeroHorizontlMovement();
    }

    private void SetHeroForwardMovement()
    {
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetHeroHorizontlMovement()
    {
        newPositionX = transform.position.x+heroInputController.HorizontalValue*horizontalMovementSpeed*Time.fixedDeltaTime;
        //clamp ile ne kadar saða veya sola götürsekte belirttiðimiz horizontal deðerdin üstüne çýkamayacak
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position=new Vector3(newPositionX,transform.position.y,transform.position.z);
    }
}
