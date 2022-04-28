using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f;

    public enum WhichWayToRotate { AroundX, AroundY, AroundZ};

    public WhichWayToRotate way = WhichWayToRotate.AroundX;

    // Update is called once per frame
    void Update()
    {
        switch (way)
        {
            case WhichWayToRotate.AroundX:
                transform.Rotate(Vector3.right * Time.deltaTime * speed);
                break;
            case WhichWayToRotate.AroundY:
                transform.Rotate(Vector3.up * Time.deltaTime * speed);
                break;
            case WhichWayToRotate.AroundZ:
                transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                break;
        }
        
    }
}
