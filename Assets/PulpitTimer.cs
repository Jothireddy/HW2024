using UnityEngine;
using TMPro;

public class PulpitTimer : MonoBehaviour
{
    public TextMeshPro timerText;
    private float timer = 3f;

    void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("TimerText not assigned!");
            return;
        }
        timerText.text = timer.ToString("F0");
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Destroy(gameObject);
        }
        else
        {
            timerText.text = Mathf.Ceil(timer).ToString("F0");
        }
    }
}
