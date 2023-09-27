using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNotEvaluable7 : MonoBehaviour
{
    public Transform target;
    public float animationTime;

    public enum ROTATION { INSTANT, ANIMATION}
    public ROTATION rotation;
    public enum MODE { ANGLE_AXIS, ROTATE}
    public MODE mode;
}
