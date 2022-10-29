using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject coin;
    
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other)
    {
        Destroy(coin);
        
    }
    
}
