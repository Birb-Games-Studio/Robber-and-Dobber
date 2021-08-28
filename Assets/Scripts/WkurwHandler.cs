using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WkurwHandler : MonoBehaviour
{

    [ProgressBar("Health", 100, EColor.Red)]
    public int health = 100;

    [ProgressBar("Anger", 100, EColor.Yellow)]
    public int anger = 50;

    [ProgressBar("Fear", 100, EColor.Blue)]
    public int fear = 35;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
