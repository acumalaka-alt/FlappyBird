using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    public float pipeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
    }
}
