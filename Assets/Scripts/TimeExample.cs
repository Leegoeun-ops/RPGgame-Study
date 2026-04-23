using UnityEngine;

public class TimeExample : MonoBehaviour
{
    public float inGameTime;
    public float lastTimeAttacked;
    public float comboResetTime = 2;

    private void Update()
    {
        inGameTime = Time.time;

        if (inGameTime > lastTimeAttacked + comboResetTime)
            Debug.Log("I can reset combo counter!");
        else
            Debug.Log("cant");
    }

    [ContextMenu("Save Attack Time")]
    public void SaveTime()
    {
        lastTimeAttacked = Time.time;
    }
}
