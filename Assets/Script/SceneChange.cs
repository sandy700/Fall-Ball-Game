using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnClick()
    {
        SceneManager.LoadScene(1);
        
    }

    public void Loading()
    {
        Invoke("OnClick", 5.0f);
    }
}
