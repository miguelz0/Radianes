using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePosition : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
        Vector3 worldMousePosition = GetWorldMousePosition();
        LookAt(worldMousePosition);
        //float radians = Mathf.Atan2(worldMousePosition.y , worldMousePosition.x);
        //RotateZ(radians);
        //worldMousePosition.Draw(Color.black);
    }

    private Vector3 GetWorldMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        return worldPos;
    }

    private void RotateZ(float radians)
    {
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, radians * Mathf.Rad2Deg);
    }
    private void LookAt(Vector3 position)
    {
        Vector4 resta = position - transform.position;
        float radians = Mathf.Atan2(resta.y, resta.x);
        RotateZ(radians);
        resta.Draw(Color.black);
        
        //Vector4 posicion = new Vector4(transform.position.x, transform.position.y,0,0);
        //Vector4 temp =  posicion;
        //temp.Draw(Color.blue);

    }
}