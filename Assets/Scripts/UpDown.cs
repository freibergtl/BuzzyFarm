using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    Rigidbody character;
    float thrust = 20f;




    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.Q))
            {
                character.AddForce(Vector3.up * thrust);
            }
      
    
            if (Input.GetKey(KeyCode.E))
            {
                character.AddForce(Vector3.down * thrust);
            }
        
    }
        
}
