using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Scan1")]
public class ScanDecision1 : Decision {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public override bool Decide(StateController controller) {
        bool noEnemyInSight = Scan(controller);
        return noEnemyInSight;
    }

    private bool Scan(StateController controller) {
        controller.navMeshAgent.Stop();
        controller.transform.Rotate(0, controller.enemyStats.searchingTurnSpeed * Time.deltaTime, 0);
        return controller.CheckIfCountdownElapsed(controller.enemyStats.searchDuration);
    }

}
