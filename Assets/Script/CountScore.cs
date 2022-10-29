using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    
    public string score;
    private void OnTriggerEnter(Collider score)
    {
        int count = 0;
        if ("score" == "Coin")
        {
            count++;
            Debug.Log(count);
        }
    }
}
