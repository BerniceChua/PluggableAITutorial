using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName ="PluggableAI/Actions/Patrol")]
public class PatrolAction : Action {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public override void Act(StateController controller) {
        Patrol(controller);
    }

    private void Patrol(StateController controller) {
        /// because this involves scene behavior, these need to be attached to add.
        /// We added `[HideInInspector] public int nextWaypoint;` in StateController at this time.
        controller.navMeshAgent.destination = controller.wayPointList[controller.nextWaypoint].position;

        /// starts the agent to walk
        controller.navMeshAgent.Resume();

        /// check if reached destination, then pick a new waypoint.
        if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance && !controller.navMeshAgent.pathPending) {
            /// the modulo operator allows us to loop back to the 1st waypoint if we go over.
            controller.nextWaypoint = (controller.nextWaypoint + 1) % controller.wayPointList.Count;
        }

    }

}
