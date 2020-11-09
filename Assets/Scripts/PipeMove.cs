using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float Speed;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
