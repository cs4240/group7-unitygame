using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronScript : MonoBehaviour
{
    public GameObject atomBase;
    public float speed, distanceFromCenter;

    private Vector3 updatedUp;
    // Start is called before the first frame update
    void Start()
    {
        //To get the new up from the new front distance
        Vector3 front, right;
        front = transform.position - atomBase.transform.position;
        right = Vector3.Cross(front.normalized, new Vector3(0, 1, 0));
        updatedUp = Vector3.Cross(right, front);

        //To set the distance from the center
        transform.position = atomBase.transform.position + distanceFromCenter * front.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(atomBase.transform.position, updatedUp, speed * Time.deltaTime);
    }
}
