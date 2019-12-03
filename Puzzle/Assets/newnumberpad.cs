using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newnumberpad : MonoBehaviour
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
    Material material;
    public int color;

    public Color[] colors = { new Color(0, 1, 0, 1), new Color(1, 0, 0, 1), new Color(1, 1, 1, 1), new Color(0, 0, 1, 1) };

    public bool test = true;

    void Start()
    {
        //Set the vector, which you use to move the RigidBody upwards straight away
        myVector = new Vector3(1.0f, 0.0f, 0.0f);
        defVec = transform.position;
        defVec2 = new Vector3(0f, 0.0f, 0.05f);
        //Fetch the RigidBody you attach to the GameObject
        material = GetComponent<Renderer>().material;
        m_Rigidbody = GetComponent<Rigidbody>();
        color = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*
        if (Pressed)
        {
            if(color == 0)
            {
                material.color = Color.blue;
                color = 1;
            }
            else if(color == 1)
            {
                material.color = Color.green;
                color = 2;
            }
            else if (color == 2)
            {
                material.color = Color.yellow;
                color = 3;
            }
            else if (color == 3)
            {
                material.color = Color.magenta;
                color = 4;
               
            }
            else
            {
                material.color = Color.red;
                color = 0;
            }
          
           
        }
        */

    }


    void Update()
    {

        if (transform.position.z >= defVec.z && transform.position.z <= (defVec + defVec2).z)
        {
            m_Rigidbody.velocity = myVector * m_Speed;
        }
        else if (transform.position.z >= defVec.z)
        {
            transform.position = defVec + defVec2;
        }
        else
        {
            m_Rigidbody.velocity = myVector * 0;
            transform.position = defVec;
        }

        if (transform.position.z <= (defVec + defVec2).z && transform.position.z > defVec.z)
        {
         
            Pressed = true;
            if (!test)
            {
                if (color < 3)
                {
                    color++;
                }
                else
                {
                    color = 0;
                }
                material.color = colors[color];
               test = true;
            }
   
        }
        else
        {
            Pressed = false;
            test = false;

        }

        

    }
}
