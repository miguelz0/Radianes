using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seno : MonoBehaviour
{
    public float periodox, amplitudx, periodoy, amplitudy;
   


    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float factorx = Time.time / periodox;
        float factory = Time.time / periodoy;
        float x = amplitudx * Mathf.Sin(2 * Mathf.PI * factorx);        
        float y = amplitudy * Mathf.Sin(2*Mathf.PI*factory);

        transform.position = new Vector3(x, y, 0);

    }
}
