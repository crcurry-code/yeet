using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public float endstop;//how far down you want the button to be pressed before it triggers
    public bool Pressed = false;
    public int numPressed = 0;
    Collider m_Collider;
    Vector3 myVector;
    Vector3 defVec;
    Vector3 defVec2;
    Rigidbody m_Rigidbody;
    float m_Speed = 2.0f;

    void Start()
    {
        //Set the vector, which you use to move the RigidBody upwards straight away
        myVector = new Vector3(0.0f, 1.0f, 0.0f);
        defVec = transform.position;
        defVec2 = new Vector3(0.0f, 0.181f, 0.0f);
        //Fetch the RigidBody you attach to the GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (Pressed)
        {
            numPressed++;
        }
    }

    void Update()
    {
       
        //Move the RigidBody upwards at the speed you define
        if (transform.position.y <= defVec.y && transform.position.y>= (defVec-defVec2).y)
        {
            m_Rigidbody.velocity = myVector * m_Speed;
        }
        else if(transform.position.y < (defVec-defVec2).y)
            {
               transform.position = defVec-defVec2;
            }
        else
        {
            m_Rigidbody.velocity = myVector * 0;
            transform.position = defVec;
        }
      
        if (transform.position.y > (defVec-defVec2).y && transform.position.y < defVec.y)
        {
            Pressed = true;
            
        }
        else
        {
            Pressed = false;
        }
       
    }
}