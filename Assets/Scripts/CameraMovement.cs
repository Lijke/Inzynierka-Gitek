using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float Speed;

    public void Update()
    {
        // if our finger is on the screen and it has moved from its start position than do the code 
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x * Speed, -TouchDeltaPosition.y * Speed, 0);
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, 0f, 50f),
                Mathf.Clamp(transform.position.y, 13f, 13f),
                Mathf.Clamp(transform.position.z, 0f, 50f));
        }
    }
}