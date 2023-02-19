using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public GameObject losePage;
    public Image timerFill;
    float remainTime;
    public float maxTime;
    
    // Start is called before the first frame update
    void Start()
    {
        remainTime = maxTime;
        losePage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(remainTime > 0)
        {
            remainTime -= Time.deltaTime;
            timerFill.fillAmount = remainTime / maxTime;
        }
        else
        {
            losePage.SetActive(true);
            Cursor.SetCursor(default, new Vector2(0, 0), CursorMode.Auto);
        }
    }
}
