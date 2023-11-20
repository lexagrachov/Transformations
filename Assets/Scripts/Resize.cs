using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Resize : Transformation
{
    [SerializeField] private float _changedSize;

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
}
