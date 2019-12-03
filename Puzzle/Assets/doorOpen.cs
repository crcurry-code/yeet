using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    Vector3 open;
    Vector3 myVector;
    Vector3 startPos;
    Rigidbody rig;
    float m_Speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        open = new Vector3(15f,-3.17f , -44f);
        myVector = new Vector3(0.0f, -1.0f, 0.0f);
        startPos = new Vector3(15f, 2.5f, -44f);
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame

    void Update()
    {
        /*
        if (GameObject.Find("Button").GetComponent<Button>().numPressed==9)
        {
            transform.position = open;
        }

        if (GameObject.Find("KeyPad1").GetComponent<HoriButton>().on == 1&&(GameObject.Find("KeyPad4").GetComponent<HoriButton>().on == 1)&&(GameObject.Find("KeyPad7").GetComponent<HoriButton>().on == 1)&&(GameObject.Find("KeyPad8").GetComponent<HoriButton>().on == 1))
        {
            transform.position = open;
        }
        */

        
            if (GameObject.Find("KeyPad1").GetComponent<HoriButton>().on == 1 && GameObject.Find("KeyPad2").GetComponent<HoriButton>().on==-1 && GameObject.Find("KeyPad6").GetComponent<HoriButton>().on == -1)
            {
                if (GameObject.Find("KeyPad4").GetComponent<HoriButton>().on == 1 && GameObject.Find("KeyPad3").GetComponent<HoriButton>().on == -1)
                {
                    if (GameObject.Find("KeyPad7").GetComponent<HoriButton>().on == 1 && GameObject.Find("KeyPad5").GetComponent<HoriButton>().on == -1) 
                    {
                        if (GameObject.Find("KeyPad8").GetComponent<HoriButton>().on == 1 && GameObject.Find("KeyPad9").GetComponent<HoriButton>().on == -1)
                        {

                           Destroy(gameObject);

                        }
                    }
                }
            }

       
    }
}
