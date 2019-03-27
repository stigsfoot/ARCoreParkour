using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        transform.Rotate(0, 25 * Time.deltaTime,0);
    }
}
