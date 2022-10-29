using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class AppExit : MonoBehaviour {


    public void TaskOnClick()
    {
        Application.Quit ();
        Debug.Log("You touched this button.");
    }
    }