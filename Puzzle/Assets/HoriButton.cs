using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoriButton : MonoBehaviour
{

    public float endstop;//how far down you want the button to be pressed before it triggers
    public bool Pressed = false;
    public int numPressed = 0;
    public int on = -1;
    Collider m_Collider;
    Vector3 myVector;
    Vector3 defVec;
    Vector3 defVec2;
    Rigidbody m_Rigidbody;
    float m_Speed = 2.0f;
    Material material;
    public bool test = true;
    public int color;


    public Color[] colors = { new Color(1, 0, 0, 1), new Color(0, 1, 0, 1) };
    void Start()
    {
        //Set the vector, which you use to move the RigidBody upwards straight away
        myVector = new Vector3(1.0f, 0.0f, 0.0f);
        defVec = transform.position;
        defVec2 = new Vector3(.05f, 0.0f, 0.0f);
        //Fetch the RigidBody you attach to the GameObject
        material = GetComponent<Renderer>().material;
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (Pressed)
        { 
            on *= -1;
            numPressed++;
            
        }

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
                
                
                  material.color = colors[1];
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
