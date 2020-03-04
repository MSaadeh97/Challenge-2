using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 a, b;
    [Range(0, 1)]
    public float speed = 1.0f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.Lerp(a, b, Mathf.PingPong(Time.time * speed, 1));
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
