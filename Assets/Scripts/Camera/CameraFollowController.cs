using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;
    private Vector3 offset;
    private Vector3 newPosition;
    [SerializeField] private float lerpValue;


    private void Start()
    {
        //kamera �le hero aras�ndaki mesafeyi tuttuk.
        offset= transform.position-heroTransform.position;
    }

    private void LateUpdate()
    {
        //LATE UPDATEDE KAMERA TAK�PTE �NER�LEN.
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.z) + offset, lerpValue * Time.deltaTime);

        transform.position = newPosition;
    }
}
