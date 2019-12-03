using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePoints : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("InnerTarget").GetComponent<InnerPoints>().score += 25;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
