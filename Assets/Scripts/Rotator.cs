using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 rotationDelta = Vector3.up * _speed * Time.deltaTime;

        transform.Rotate(rotationDelta);
    }
}
