using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Action<float> Kill;
    public GameObject bulletPrefab;
    public Transform firePos;
    public int mission;

    public Text leftText;
    public Text pointText;
    public GameObject winPanel;
    private int _left;
    private int _point;

    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
        _left = mission;
        Kill += OnKill;
    }

    private void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
            if (Input.GetTouch(i).phase == TouchPhase.Began)
                Shoot();

        if (Input.GetKeyDown(KeyCode.Space)) Shoot();
    }

    private void OnDisable()
    {
        Kill -= OnKill;
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        _source.Play();
    }

    private void OnKill(float distance)
    {
        _left -= 1;
        leftText.text = $"{_left} / {mission}";

        _point += (int) (distance * 100);
        pointText.text = $"{_point}";

        if (_left <= 0) OnClear();
    }

    private void OnClear()
    {
        winPanel.SetActive(true);
    }
}