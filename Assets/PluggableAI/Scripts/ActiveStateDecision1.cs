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
        //if (FindObjectOfType<Target>()) {
        //    TargetsAndArrayList.CountThingsInArrayList();
        //    Debug.Log("Inside ActiveStateDecision1.Decide()");
        //    Debug.Log("FindObjectOfType<Target>().name = " + FindObjectOfType<Target>().name);
        //    return true;
        //} else {
        //    return false;
        //}

        //bool chaseTargetIsActive = TargetsAndArrayList.GetNearestInArrayList().activeSelf;
        //return chaseTargetIsActive;

        bool chaseTargetIsActive = TargetsAndArrayList.GetNearestInArrayList().activeSelf;
        //bool chaseTargetIsActive = controller.chaseTarget.gameObject.activeSelf;
        //if (chaseTargetIsActive) {
        //Target target = FindObjectOfType<Target>();
        //if (target != null && TargetsAndArrayList.CountThingsInArrayList() != 0 && chaseTargetIsActive) {
        if (chaseTargetIsActive) {
            //Debug.Log(TargetsAndArrayList.CountThingsInArrayList());
            Debug.Log("Inside ActiveStateDecision1.Decide() \n TargetsAndArrayList.GetNearestInArrayList().name = " + TargetsAndArrayList.GetNearestInArrayList().name);
            return true;
        }
        else {
            return false;
        }

    }

}
