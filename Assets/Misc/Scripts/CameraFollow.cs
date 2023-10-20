using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - target.position;
    }

    private void Update()
    {
        transform.position = new Vector3(target.position.x + _offset.x, target.position.y + _offset.y, target.position.z + _offset.x);
    }

}
