using System.Collections;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float distance;
    public float gapTime;

    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(RepeatGenerate());
    }

    private void OnDestroy()
    {
        StopCoroutine(_coroutine);
    }

    private IEnumerator RepeatGenerate()
    {
        while (true)
        {
            Generate();
            yield return new WaitForSeconds(gapTime);
        }
    }


    private GameObject Generate()
    {
        var pos = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        pos = Vector3.Normalize(pos) * distance;

        return Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}