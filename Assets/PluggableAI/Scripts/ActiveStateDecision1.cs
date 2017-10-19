using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/ActiveState1")]
public class ActiveStateDecision1 : Decision {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public override bool Decide(StateController controller) {
        //bool chaseTargetIsActive = controller.chaseTarget.gameObject.activeSelf;
        //bool chaseTargetIsActive = FindObjectOfType<Target>().gameObject.activeSelf;
        //if (FindObjectOfType<Target>().gameObject.activeSelf != null) {
        if (FindObjectOfType<Target>()) {
            return true;
        } else {
            return false;
        }
    }

}
