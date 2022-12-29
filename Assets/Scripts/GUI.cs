using UnityEngine;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }

    public void OnNext(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}