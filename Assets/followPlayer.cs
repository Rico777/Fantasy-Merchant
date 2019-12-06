using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform py;

    public Transform cm;

    public Vector3 offset;
    public int x, y, z;

    private void Start()
    {
        offset.x = x;
        offset.y = y;
        offset.z = z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        cm.position = py.position + offset;
    }
}
