using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    public MonoBehaviour Move;
    public Navigation_Controller nav;
    void OnEnable()
    {
        Debug.Log("Current State: Idle");
    }

    void Update()
    {
        if (nav.hasItArrived() > 1)
        {
           
            transform.SendMessage("ActivateState", Move);
        }
    }
}
