using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public static PlatformMove instance;
    public float moveSpeed = 2f;
    public float deadZone = -18;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            GameObject nestedObject = GameObject.FindGameObjectWithTag("Obstacle");

            if (nestedObject != null)
            {
                Destroy(nestedObject.gameObject);
            }
        }
    }
}
