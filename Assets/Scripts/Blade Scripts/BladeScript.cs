using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeScript : MonoBehaviour
{
    public static BladeScript instance;

    [SerializeField]
    public float rotateSpeed = 0.2f;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }
}
