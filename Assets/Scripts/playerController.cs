using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // back is right
    // forward is left
    void Update()
    {
        transform.Translate(Vector3.right * speed);
        transform.Rotate(Vector3.back);
    }
}
