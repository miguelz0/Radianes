using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radianes : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 cartesiano;
    public float radio = 1, angulo, rapidezradio, aceleracionradio=0.5f, rapidezangulo, aceleracionangulo=0.5f, radiolimite;
    
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        Limites();
        rapidezradio = rapidezradio + Time.deltaTime * aceleracionradio;
        rapidezangulo = rapidezangulo + Time.deltaTime * aceleracionangulo;
        cartesiano = CoordenadasPolares();
        cartesiano.Draw(Color.black);
        radio = radio + rapidezradio*Time.deltaTime;
        angulo = angulo + rapidezangulo*Time.deltaTime;
        transform.position = cartesiano;
        
        
        
    }
    public Vector2 CoordenadasPolares()
    {
        Vector2 temp = new Vector2(0, 0);
        temp.x = Mathf.Cos(angulo);
        temp.y = Mathf.Sin(angulo);
        temp= temp* radio;
        return (temp);
    }
    public void Limites()
    {

        if (radio >=5)
        {
            aceleracionradio = -aceleracionradio * Time.deltaTime;
        }        
    }
    
}
