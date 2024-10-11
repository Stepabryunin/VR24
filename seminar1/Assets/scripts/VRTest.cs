using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRTest : MonoBehaviour
{
    
    public Text MyText;
    private int x = 9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()  
    {
        x++;
        MyText.text = x.ToString();
        
    }
}
