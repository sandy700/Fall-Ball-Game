using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetActive : MonoBehaviour
{
    public GameObject sandeep;
    void Start()
    {
        transform.position = new Vector3(-0.6f, 8.8f, -10.3f);
        transform.eulerAngles = new Vector3(10, 5, 1);
        transform.localScale = new Vector3(5, 5, 5);



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            Destroy(sandeep);
        }
        
        if(Input.GetKey("a"))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.1f);
        }

        
    }
}
