using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 7f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}