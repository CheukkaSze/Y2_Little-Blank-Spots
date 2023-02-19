using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cleanliness : MonoBehaviour
{
    public CursorController cursorController;
    public Slider slider;
    public TMP_Text cleanTxt;
    public GameObject winPage;
    private bool isWin;
    public AudioSource spray;
    public AudioSource bat;
    public int maxMark;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        winPage.SetActive(false);
        isWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        cleanTxt.text = slider.value.ToString();

        if (slider.value == maxMark)
        {
            winPage.SetActive(true);
            isWin = true;
        }

        if (isWin)
        {
            Time.timeScale = 0f;
            Cursor.SetCursor(default, new Vector2(0,0), CursorMode.Auto);
        }

        void OnMouseDown()
        {
            if (cursorController.sprayMode)
            {
                spray.Play();
            }
            if (cursorController.slipperMode||cursorController.batMode)
            {
                bat.Play();
            }
        }
    }

    public void SlipperAddMarks()
    {
        if (cursorController.slipperMode)
        {
            slider.value += 10;
        }   
    }

    public void BatAddMarks()
    {
        if (cursorController.batMode)
        {
            slider.value += 10;
        }
    }

    public void SprayAddMarks()
    {
        if (cursorController.sprayMode)
        {
            slider.value += 10;
        }
    }
}
