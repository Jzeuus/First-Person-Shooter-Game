using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour{
    public float spinSpeed = 100f;
    public float motionSpeed = 10f;
    public float motionMagnitude = 0.5f;
    public enum MotionDirection { Spin, Horizontal, Vertical};
    public MotionDirection motionState = MotionDirection.Horizontal;

    // Update is called once per frame
    void Update()
    {
        switch (motionState)
        {
            case MotionDirection.Spin:
                gameObject.transform.Rotate(Vector3.up *
                    Time.deltaTime * spinSpeed);
                break;
            case MotionDirection.Horizontal:
                gameObject.transform.Translate(Vector3.right *
                    Mathf.Cos(Time.timeSinceLevelLoad * motionSpeed)
                    * motionMagnitude);
                break;
            case MotionDirection.Vertical:
                gameObject.transform.Translate(Vector3.up *
                   Mathf.Cos(Time.timeSinceLevelLoad * motionSpeed)
                   * motionMagnitude);
                break;
        }

    }
}
