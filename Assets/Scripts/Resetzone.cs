using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetzone : MonoBehaviour
{
    public bool isSolved = false;
    public ObjectReset objectReset;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
            if (collidedWith.tag == gameObject.tag)
        {
            

            objectReset.ResetObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
