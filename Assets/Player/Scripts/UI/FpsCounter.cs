using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        float fps = 1.0f / Time.deltaTime;
        textMeshPro.text = (int)fps + "FPS";
    }
}
