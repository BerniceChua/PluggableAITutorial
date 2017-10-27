using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Chase1")]
public class ChaseAction1 : Action {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public override void Act(StateController controller) {
        Chase(controller);
    }

    private void Chase(StateController controller) {
        controller.navMeshAgent.destination = controller.chaseTarget.position;
        Debug.Log("Inside ChaseAction1.Chase()");
        Debug.Log("controller.navMeshAgent.destination = " + controller.navMeshAgent.destination);
        controller.navMeshAgent.Resume();
    }

}
