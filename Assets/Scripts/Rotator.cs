using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 50f;

    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }
}