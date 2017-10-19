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

        //if (target.isActiveAndEnabled) {
        if (target != null) {
            controller.chaseTarget = target.transform;
            return true;
        } else {
            return false;
        }
    }

}
