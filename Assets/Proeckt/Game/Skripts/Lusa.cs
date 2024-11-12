using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI
    ;
public class Lusa : MonoBehaviour
{
    public Text scores;
    public Data data;

    public void OnClick() 
    {
        data.scores += 1;
    }
    private void FixedUpdate()
    {
        scores.text = "" + data.scores;
    }
}
