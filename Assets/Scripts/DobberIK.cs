using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobberIK : MonoBehaviour
{
    public bool useHeadIK;

    [Header("Targets")]
    public Transform headTarget;
    public Transform leftWingTarget;
    public Transform rightWingTarget;
    public Transform leftFootTarget;
    public Transform rightFootTarget;

    [Header("Bones")]
    public Transform headBone;
    public Transform leftWingBone;
    public Transform rightWingBone;
    public Transform leftFootBone;
    public Transform rightFootBone;

    // Update is called once per frame
    void Update()
    {
        if (useHeadIK)
        {
            headTarget.position = headBone.position;
        }

        leftFootTarget.position = leftFootBone.position;
        leftWingTarget.position = leftWingBone.position;
        rightFootTarget.position = rightFootBone.position;
        rightWingTarget.position = rightWingBone.position;
    }
}
