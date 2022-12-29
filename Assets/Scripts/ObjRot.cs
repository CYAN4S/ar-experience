using UnityEngine;

public class ObjRot : MonoBehaviour
{
    public float rotSpeed = 100f;

    private void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }
}