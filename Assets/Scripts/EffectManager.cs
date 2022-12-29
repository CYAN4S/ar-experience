using System;
using System.Collections;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static Action<Vector3> CallEffect;

    public GameObject effectPrefab;

    private void Awake()
    {
        CallEffect += CreateEffect;
    }

    private void OnDestroy()
    {
        CallEffect -= CreateEffect;
    }

    private void CreateEffect(Vector3 pos)
    {
        var tmp = Instantiate(effectPrefab, pos, Quaternion.identity);
        StartCoroutine(DestroyLater(tmp));
    }

    private IEnumerator DestroyLater(GameObject target)
    {
        yield return new WaitForSeconds(3f);
        Destroy(target);
    }
}