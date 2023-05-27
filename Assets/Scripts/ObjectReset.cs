using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReset : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation; 
    }

    public void ResetObject()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
