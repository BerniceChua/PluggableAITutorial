using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Look1")]
public class LookDecision1 : Decision {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public override bool Decide(StateController controller) {
        bool targetVisible = Look(controller);
        return targetVisible;
    }

    private bool Look(StateController controller) {
        //RaycastHit hit;

        /// Will draw a green line in front of where this is looking.
        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.enemyStats.lookRange, Color.green);

        Target target = FindObjectOfType<Target>();
        //Target target = TargetsAndArrayList.GetNearestInArrayList().GetComponent<Target>();

        //if (target.isActiveAndEnabled) {
        //if (target != null) {
        //if (TargetsAndArrayList.GetNearestInArrayList().GetComponent<Target>() != null) {
        if (TargetsAndArrayList.CountThingsInArrayList() != 0) {
        //if (target != null && TargetsAndArrayList.CountThingsInArrayList() != 0) {
            if (TargetsAndArrayList.GetNearestInArrayList().activeSelf) {
                //controller.chaseTarget = target.transform;
                controller.chaseTarget = TargetsAndArrayList.GetNearestInArrayList().GetComponent<Target>().transform;
                Debug.Log("Inside LookDecision1.Look()");
                Debug.Log("controller.chaseTarget = " + controller.chaseTarget);
                return true;
            } else {
                return false;
            }
        } else {
            return false;
        }
    }

}
