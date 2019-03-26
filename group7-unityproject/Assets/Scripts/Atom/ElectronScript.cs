using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronScript : MonoBehaviour
{
    public GameObject atomBase;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(atomBase.transform.position, atomBase.transform.up, speed * Time.deltaTime);
    }
}
