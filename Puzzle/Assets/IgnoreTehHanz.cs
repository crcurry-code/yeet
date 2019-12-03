using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTehHanz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        print(col);
        if (col.gameObject.tag == "Hand")
        {
            Physics.IgnoreCollision(col.collider, GetComponent<Collider>());
        }

    }
}
