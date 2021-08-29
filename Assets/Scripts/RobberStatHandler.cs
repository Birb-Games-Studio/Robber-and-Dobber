using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RobberStatHandler : MonoBehaviour
{
    [BoxGroup("Helth")]
    public Slider helthBar;

    [BoxGroup("Helth")]
    public TMP_Text helthValue;

    [MinValue(0), MaxValue(100), BoxGroup("Helth")]
    public int health = 100;

    [BoxGroup("Anger")]
    public Slider angerBar;

    [BoxGroup("Anger")]
    public TMP_Text angerValue;

    [MinValue(0), MaxValue(100),BoxGroup("Anger")]
    public int anger = 0;

    [BoxGroup("Fear")]
    public Slider fearBar;

    [BoxGroup("Fear")]
    public TMP_Text fearValue;

    [MinValue(0), MaxValue(100), BoxGroup("Fear")]
    public int fear = 0;

    private void Update()
    {

        helthBar.value = health;
        helthValue.text = helthBar.value.ToString() + "%";
        angerBar.value = anger;
        angerValue.text = angerBar.value.ToString() + "%";
        fearBar.value = fear;
        fearValue.text = fearBar.value.ToString() + "%";

    }

}
