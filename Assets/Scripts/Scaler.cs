using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private float _minScale = 0.5f;
    private float _maxScale = 2f;
    private Vector3 _initialScale;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    private void Update()
    {
        float pingPongValue = Mathf.PingPong(Time.time * _speed, 1f);
        float currentScale = Mathf.Lerp(_minScale, _maxScale, pingPongValue);
        transform.localScale = _initialScale * currentScale;
    }
}