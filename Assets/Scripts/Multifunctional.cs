using UnityEngine;

public class Multifunctional : MonoBehaviour
{
    [SerializeField] private float _speed = 7f;
    [SerializeField] private float _speedScale = 0.5f;
    [SerializeField] private float _speedRotation = 50f;

    private float _minScale = 0.5f;
    private float _maxScale = 2f;
    private Vector3 _initialScale;
    private Vector3 _MoveForward;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    void Update()
    {
        Movement();
        GrowsInSize();
        Rotation();
    }

    private void Movement()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void GrowsInSize()
    {
        float pingPongValue = Mathf.PingPong(Time.time * _speedScale, 1f);
        float currentScale = Mathf.Lerp(_minScale, _maxScale, pingPongValue);
        transform.localScale = _initialScale * currentScale;
    }

    private void Rotation()
    {
        transform.RotateAround(transform.position, transform.up, _speedRotation*Time.deltaTime);
    }
}
