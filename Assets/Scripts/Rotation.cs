using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _anglePerSecond;

    private void FixedUpdate()
    {
        transform.Rotate(0, _anglePerSecond * Time.deltaTime, 0);
    }
}
