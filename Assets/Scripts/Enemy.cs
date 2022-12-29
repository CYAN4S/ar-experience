using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private readonly Vector3 _destination = new(0, 0, 0);

    private AudioSource _audio;
    private bool _inLimited;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _inLimited = false;
    }

    private void Update()
    {
        if (!_inLimited) transform.position = Vector3.Slerp(transform.position, _destination, speed);

        transform.LookAt(_destination);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AudioManager.CallAudioPlay();
            EffectManager.CallEffect(transform.position);

            var distance = Vector3.Distance(transform.position, Vector3.zero);

            Player.Kill(distance);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.CompareTag("Limited"))
        {
            _inLimited = true;
            Debug.Log("LIM");
        }
    }
}