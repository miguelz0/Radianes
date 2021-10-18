using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
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
        LookAt(posicion+velocidad);
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
        velocidad = velocidad + aceleracion * Time.deltaTime;
        posicion = posicion + velocidad * Time.deltaTime;
    }

    public void Rastreo()
    {
        aceleracion.x = (PosMouse.x - transform.position.x);
        aceleracion.y = (PosMouse.y - transform.position.y);
        aceleracion.Normalize();
        aceleracion = aceleracion * factor;
    }
    public void Rotacion()
    {
        velocidad.Normalize();

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

    }
}

