using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronScript : MonoBehaviour
{
    public GameObject atomBase;
    public float speed;

    private Vector3 up;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 front, right;
        front = transform.position - atomBase.transform.position;
        front = front.Normalize;
        right = Vector3.Cross(front.Normalize, new Vector3(0, 1, 0));
        up = Vector3.Cross(right, front);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(atomBase.transform.position, atomBase.transform.up, speed * Time.deltaTime);
    }
}
