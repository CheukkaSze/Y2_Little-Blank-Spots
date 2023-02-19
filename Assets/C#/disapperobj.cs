using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapperobj : MonoBehaviour
{
    //public GameObject dieEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        gameObject.SetActive(false);
        //Instantiate(dieEffect, transform.position, Quaternion.identity);
    }
    public void Disappear()
    {
        gameObject.SetActive(false);
    }

    

    
}
