using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonCode : MonoBehaviour
{
   

    [SerializeField]
    KeyCode KeyRestart;

   
    void FixedUpdate()
    {
        if (Input.GetKey(KeyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
