using UnityEngine;

public class LinearMovemet : Transformation
{
    [SerializeField] private bool _isReversal;
    [SerializeField] private float _reverseDistance;

    private void Start()
    {
        if (_isReversal == false)
            _reverseDistance = 0;
    }

    private void Update()
    {
        transform.Translate(0, 0 , _speed * Time.deltaTime * _directionModifier);
        _timeInCurrentDirection += Time.deltaTime;

        if(_timeInCurrentDirection * _speed >= _reverseDistance && _isReversal)
            Turning();
    }
}
