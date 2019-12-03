using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollisionHands : MonoBehaviour
{
    public Collider cool;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    void OnCollisionEnter(Collision collision)
    {
        /* if (collision.gameObject.name == "LeftHand"||collision.gameObject.name == "RightHand")
         {
             Physics.IgnoreCollision(Hand.collision<collider>(), cool);
         }
         */
        Physics.IgnoreLayerCollision(11,10);
    }



        // Update is called once per frame
        void Update()
    {
        
    }
}
