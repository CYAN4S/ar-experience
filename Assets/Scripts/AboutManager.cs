using UnityEngine;
using UnityEngine.UI;

public class AboutManager : MonoBehaviour
{
    public GameObject aboutPanel;
    public Text buttonText;

    private bool _visible;

    public void OnClick()
    {
        _visible = !_visible;

        aboutPanel.SetActive(_visible);
        buttonText.text = _visible ? "X" : "?";
    }
}