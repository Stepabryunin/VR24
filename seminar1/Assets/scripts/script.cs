using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public GameObject Sphere_object;
    public Rigidbody Spere_body;
    public Text output;
    int chetchik = 0;
    public Vector3 a=  new Vector3((float)9, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Spere_body = GetComponent<Rigidbody>();
        
        Spere_body.linearVelocity = a;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        output.text=chetchik.ToString();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            a = -a;
            Spere_body.linearVelocity = a;
            chetchik++;
           
        }
    }
}
