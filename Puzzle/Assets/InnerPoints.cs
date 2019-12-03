using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InnerPoints : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        score = score + 50;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
