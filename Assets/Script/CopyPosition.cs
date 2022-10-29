using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;

    
    void Update()
    {
        transform.position = transTarget.position;
    }
}
