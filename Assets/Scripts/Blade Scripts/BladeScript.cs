using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeScript : MonoBehaviour
{
    public static BladeScript instance;
    public float rotateSpeed = 0.2f;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }

    private void Update()
    {
        if(PauseMenuScript.isPaused == false)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }
        else if (PauseMenuScript.isPaused == true)
        {
            transform.Rotate(0, 0, 0);
        }
    }
}
