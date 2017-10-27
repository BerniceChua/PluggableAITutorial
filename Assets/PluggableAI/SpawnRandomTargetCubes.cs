using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnRandomTargetCubes : MonoBehaviour {

    [SerializeField] GameObject m_targetCube;

    [SerializeField] NavMesh m_navMesh;

    [SerializeField] NavMeshAgent m_navMeshAgent;

    [SerializeField] Transform[] wayPointsForTargets;

    int m_targetCounter = 0;

    //// Use this for initialization
    //   void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public void SpawnTargetCube() {
        Debug.Log("Clicked on the button.");
        //m_navMeshAgent.isOnNavMesh
        //m_targetCube;
        GameObject spawnedTarget;
        spawnedTarget = Instantiate(m_targetCube, wayPointsForTargets[0].position, wayPointsForTargets[0].rotation);
        spawnedTarget.name = (spawnedTarget.name + TargetCounterAddToName());

        //TargetsAndArrayList.AddToArrayList(spawnedTarget);
    }

    public string TargetCounterAddToName() {
        m_targetCounter++;
        return m_targetCounter.ToString();
    }

}
