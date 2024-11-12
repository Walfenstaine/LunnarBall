using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int balls;
    public Data data;
    public GameObject[] lives;
    public static Lives regit { get; set; }

    void Awake()
    {
        if (regit == null) 
        {
            regit = this;
        }
    }

    public void BalsTimer() 
    {
        if (balls > 1)
        {
            balls -= 1;
        }
        else 
        {
            Interface.rid.Sum(3);
        }
    }
    private void OnDestroy()
    {
        Destroy(regit);
    }
    public void Damag() 
    {
        if (data.lives > 0)
        {
            data.lives -= 1;
        }
        else 
        {
            Interface.rid.Sum(2);
        }
    }
    private void FixedUpdate()
    {
        for (int i = 0; i < lives.Length; i++) 
        {
            if (i <= data.lives)
            {
                lives[i].SetActive(true);
            }
            else 
            {
                lives[i].SetActive(false);
            }
        }
    }
}
