using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Attack1")]
public class AttackAction1 : Action {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public override void Act(StateController controller) {
        Attack(controller);
    }

    private void Attack(StateController controller) {
        RaycastHit hit;

        /// Will draw a red line in front of where this is looking.
        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.enemyStats.attackRange, Color.red);

        if (Physics.SphereCast(controller.eyes.position, controller.enemyStats.lookSphereCastRadius, controller.eyes.forward, out hit, controller.enemyStats.attackRange) && hit.collider.CompareTag("Target")) {
            if (controller.CheckIfCountdownElapsed(controller.enemyStats.attackRate)) {
                controller.tankShooting.Fire(controller.enemyStats.attackForce, controller.enemyStats.attackRate);
            }
        }
    }

}
