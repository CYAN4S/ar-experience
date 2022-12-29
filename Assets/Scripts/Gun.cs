using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    private void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
            if (Input.GetTouch(i).phase == TouchPhase.Began)
                Instantiate(bullet, transform.position, transform.rotation);
    }
}