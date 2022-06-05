using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    private Vector3 dragPos;

    [SerializeField] private Camera cam; //obiekt kamery

    
    void Update()
    {
        PanCamera();
    }

    //przesuwanie pozycji kamery (lewo, prawo, góra, dół)
    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(0)) {
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        }


        if (Input.GetMouseButton(0)) {
            dragPos = startPos - cam.WorldToScreenPoint(Input.mousePosition);
            Debug.Log(dragPos);
        }

         MoveCamera();
    }

    private void MoveCamera()
    {
        if (dragPos.x > 0)
        {
            cam.transform.position = new Vector3()
            {
                z = cam.transform.position.z,
                y= cam.transform.position.y,
                x =  cam.transform.position.x +1f*Time.deltaTime
                
            };
        }else if (dragPos.x < 0)
        {
            cam.transform.position = new Vector3()
            {
                z = cam.transform.position.z,
                y= cam.transform.position.y,
                x =  cam.transform.position.x -1f*Time.deltaTime
                
            };
        }
    }
}