using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
        if(transform.position.y < 4.86 )// transform.position.y >= -2.88)
        {
            transform.position += transform.up * speed * Time.deltaTime;
            //float verticalInput = Input.GetAxis("Vertical");

            //transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        } 

        }
        else if (Input.GetKey(KeyCode.S))
        {
            if ( transform.position.y >= -2.88)
            {
                transform.position -= transform.up * speed * Time.deltaTime;
                //float verticalInput = Input.GetAxis("Vertical");

                //transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
            }

        }



    }
}
