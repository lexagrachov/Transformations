using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _anglePerSecond;

    void FixedUpdate()
    {
        transform.Rotate(0, _anglePerSecond * Time.deltaTime, 0);
    }
}
