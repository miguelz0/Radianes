using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Vector2 velocidad, aceleracion, posicion, PosMouse;
    public float factor = 1;
    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        PosMouse = GetWorldMousePosition();
        Rastreo();
        Movimiento();
        transform.position = posicion;
        
        
       

    }
    private Vector3 GetWorldMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        return worldPos;
    }
    private void Movimiento()
    {       
        posicion = posicion + velocidad * Time.deltaTime;
    }
    
    public void Rastreo()
    {
        velocidad.x =  (PosMouse.x- transform.position.x);
        velocidad.y =  (PosMouse.y - transform.position.y);
        velocidad.Normalize();
        velocidad = velocidad * factor;
    }    
}
