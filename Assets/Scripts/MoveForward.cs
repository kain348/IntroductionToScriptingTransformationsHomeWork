using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private Vector3 _movementDirection = new Vector3(2, 0, 10);

    private Vector3 _startMovement;
    private float _limitRange = 1f;

    private void Start()
    {
        _startMovement = transform.position;
    }

    private void Update()
    {
        float time = Mathf.PingPong(Time.time* _speed, _limitRange);
        transform.position = Vector3.Lerp(_startMovement, _movementDirection, time);
    }
}