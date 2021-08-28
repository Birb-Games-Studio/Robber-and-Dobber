using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WkurwHandler : MonoBehaviour
{
    [MinValue(0), MaxValue(100)]
    public int health = 100;

    [MinValue(0), MaxValue(100)]
    public int anger = 0;

    [MinValue(0), MaxValue(100)]
    public int fear = 0;

}
