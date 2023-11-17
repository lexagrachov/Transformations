using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _changedSize;

    private int _directionModifier = 1;
    private float _timeInCurrentDirection;
    private float _currentSize;

    private void Start()
    {
        _currentSize = transform.localScale.x;
    }

    private void Update()
    {
        float resizingPerFrame = _speed * Time.deltaTime * _directionModifier;
        transform.localScale = new Vector3(_currentSize, _currentSize, _currentSize);
        _timeInCurrentDirection += Time.deltaTime;

        _currentSize += resizingPerFrame;

        if (_timeInCurrentDirection * _speed >= _changedSize)
            Turning();
    }

    private void Turning()
    {
        _directionModifier *= -1;
        _timeInCurrentDirection = 0;
    }
}
