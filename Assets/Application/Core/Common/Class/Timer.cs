using UnityEngine;

public class Timer 
{
    public void StartTimer(float maxTimer)
    {
        float timer = 0;
        
        while(timer < maxTimer)
        {
            timer += Time.deltaTime;
            Debug.Log("Time begin");

            if(timer >= maxTimer)
            {
                Debug.Log("Time Stop");
                timer = 0;
                UIManager.Instance.ActivateScreen("YouLose");
                
            }
        }
    }
}
