using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeScript : MonoBehaviour
{
    [SerializeField]
    public float rotateSpeed = 0.2f;

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }
}
