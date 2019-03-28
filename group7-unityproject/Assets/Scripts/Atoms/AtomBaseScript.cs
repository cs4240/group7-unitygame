using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomBaseScript : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotateSpeed * Time.deltaTime, 0.75f * rotateSpeed * Time.deltaTime, 0.5f * rotateSpeed * Time.deltaTime));
    }
}
