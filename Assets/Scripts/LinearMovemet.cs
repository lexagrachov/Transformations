using UnityEngine;

public class LinearMovemet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isReversal;
    [SerializeField] private float _reverseDistance;

    private int _directionModifier = 1;
    private float _timeInCurrentDirection;

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

    private void Turning()
    {
        _directionModifier *= -1;
        _timeInCurrentDirection = 0;
    }
}
