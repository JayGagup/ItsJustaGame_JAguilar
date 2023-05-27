using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.forward, -.1f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.back, -.1f); 
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(-.1f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(.1f, 0f, 0f);
        }
    }
}
