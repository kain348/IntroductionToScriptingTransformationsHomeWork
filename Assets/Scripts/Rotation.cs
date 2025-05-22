using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed = 50f;

    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }
}
