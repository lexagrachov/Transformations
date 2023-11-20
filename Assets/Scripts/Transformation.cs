using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] protected float _speed;

    protected int _directionModifier = 1;
    protected float _timeInCurrentDirection;

    protected void Turning()
    {
        _directionModifier *= -1;
        _timeInCurrentDirection = 0;
    }
}
