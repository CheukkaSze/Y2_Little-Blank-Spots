using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    
    public Texture2D slipperUp,slipperDown,batUp,batDown,sprayUp,sprayDown;
    public bool slipperMode;
    public bool batMode;
    public bool sprayMode;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        slipperMode = false;
        batMode = false;
        sprayMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (slipperMode)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ActivateSlippeDown();
            }
            if(Input.GetMouseButtonUp(0))
            {
                ActivateSlipperUp();
            }
        }
        if (batMode)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ActivateBatDown();
            }
            if (Input.GetMouseButtonUp(0))
            {
                ActivateBatUp();
            }
        }
        if (sprayMode)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ActivateSprayDown();
            }
            if (Input.GetMouseButtonUp(0))
            {
                ActivateSprayUp();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            batMode = false;
            sprayMode = false;
            slipperMode = true;
            ActivateSlipperUp();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            batMode = false;
            slipperMode = false;
            sprayMode = true;
            ActivateSprayUp();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            slipperMode = false;
            sprayMode = false;
            batMode = true;
            ActivateBatUp();
        }
    }

    public void SlipperMode()
    {
        batMode = false;
        sprayMode = false;
        slipperMode = true;
    }
    public void SprayMode()
    {
        batMode = false;
        slipperMode = false;
        sprayMode = true;
    }
    public void BatMode()
    {
        slipperMode = false;
        sprayMode = false;
        batMode = true;
    }

    void ActivateSlipperUp()
    {
        Cursor.SetCursor(slipperUp, new Vector2(slipperUp.width / 4, slipperUp.height / 4), CursorMode.Auto);
    }

    void ActivateSlippeDown()
    {
        Cursor.SetCursor(slipperDown, new Vector2(slipperUp.width / 4, slipperUp.height / 4), CursorMode.Auto);
    }
    void ActivateBatUp()
    {
        Cursor.SetCursor(batUp, new Vector2(batUp.width / 4, batUp.height / 4), CursorMode.Auto);
    }

    void ActivateBatDown()
    {
        Cursor.SetCursor(batDown, new Vector2(batUp.width / 4, batUp.height / 4), CursorMode.Auto);
    }
    void ActivateSprayUp()
    {
        Cursor.SetCursor(sprayUp, new Vector2(sprayUp.width / 4, sprayUp.height / 4), CursorMode.Auto);
    }

    void ActivateSprayDown()
    {
        Cursor.SetCursor(sprayDown, new Vector2(sprayUp.width / 4, sprayUp.height / 4), CursorMode.Auto);
    }


}
