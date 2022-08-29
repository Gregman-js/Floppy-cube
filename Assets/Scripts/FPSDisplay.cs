using TMPro;
using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
    public TextMeshProUGUI FpsText;

    private float pollingTime = 0.5f;

    private float time;

    private int frameCount;
    
    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
