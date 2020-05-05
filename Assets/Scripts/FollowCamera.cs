using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Vector3 Offset = new Vector3();
    public float Top = 0f;

    public Transform Target { get; set; }
    void Update()
    {
        if (Target != null)
        {
            var offset = Offset;
            offset.y += Top;
            transform.position = Target.position + offset;
            transform.LookAt(Target);
        }
    }
}
