using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen2 : MonoBehaviour
{
    Vector3 open;
    Vector3 startPos;

    public GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        open = new Vector3(15f, -3.17f, -44f);
        startPos = new Vector3(15f, 2.5f, -44f);

        buttons[0] = GameObject.Find("ColorButton1");
        buttons[1] = GameObject.Find("ColorButton2");
        buttons[2] = GameObject.Find("ColorButton3");
        buttons[3] = GameObject.Find("ColorButton4");

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

       if (buttons[0].GetComponent<colorButton>().color == 1)
        {
            
            if (buttons[1].GetComponent<colorButton>().color == 1)
            {
                if (buttons[2].GetComponent<colorButton>().color == 1)
                {
                    if (buttons[3].GetComponent<colorButton>().color == 1)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }

    }
}
