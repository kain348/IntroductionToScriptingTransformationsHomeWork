using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 50f;

    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speedRotation * Time.deltaTime);
    }
}