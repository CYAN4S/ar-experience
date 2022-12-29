using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float power;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _rigidbody.AddRelativeForce(new Vector3(0, 0, power));
        Destroy(gameObject, 5.0f);
    }
}