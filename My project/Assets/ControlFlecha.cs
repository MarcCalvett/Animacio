using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlecha : MonoBehaviour
{
    float acc;
    // Start is called before the first frame update
    void Start()
    {
        acc = 0;
    }

    // Update is called once per frame
    void Update()
    {        

        if(Input.GetKey(KeyCode.A)) {
            Vector3 newRotaton = Vector3.zero;
            newRotaton.z += 1 * Time.deltaTime;
            this.transform.Rotate(Vector3.forward, 300 * Time.deltaTime);
        }        
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newRotaton = Vector3.zero;
            newRotaton.z += 1 * Time.deltaTime;
            this.transform.Rotate(-Vector3.forward, 300 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            acc = 0.001f;
        }

        acc -= Time.deltaTime * 0.001f;
        if(acc < 0) { acc = 0; }

        float ang = this.transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
         
        Debug.Log("Angle: " + ang);
        Debug.Log("Sin: " + Mathf.Sin(ang));
        Debug.Log("Cos: " + Mathf.Cos(ang)); 

        
        transform.position += new Vector3(Mathf.Cos(ang) * acc, Mathf.Sin(ang) * acc, 0);
        
    }       

        
    
}
