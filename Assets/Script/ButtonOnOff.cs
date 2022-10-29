using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOnOff : MonoBehaviour
{
    public GameObject Ui;
    bool check;
    void Start()
    {
        check = true;
    }
    public void click()
    {
        if (check == true)
        {
            Ui.SetActive(false);
            check = false;
        }
        else if (check == false)
        {
            Ui.SetActive(true);
            check = true;
        }
    }
}
