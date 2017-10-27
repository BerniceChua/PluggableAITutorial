using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class TargetsAndArrayList {

    /*[HideInInspector]*/ public static List<GameObject> m_TargetsList = new List<GameObject>();

    //// Use this for initialization
    //void Start () {
    //if (m_TargetsList == null) {
    //           m_TargetsList = new ArrayList();
    //       }


    //   }

    //// Update is called once per frame
    //void Update () {
    //       //if (FindObjectOfType<Target>()) {
    //       //    return true;
    //       //}
    //}

    public static void AddToArrayList(GameObject targetWithThisName) {
        // Add target to the ArrayList.
        m_TargetsList.Add(targetWithThisName);
        Debug.Log(targetWithThisName + " has been added to the List.");
        //Debug.Log("CountThingsInArrayList() = " + CountThingsInArrayList());
    }

    public static void RemoveFromArrayList(GameObject targetWithThisName) {
        // Remove target from the ArrayList.
        m_TargetsList.Remove(targetWithThisName);
        Debug.Log(targetWithThisName + " has been removed from the List.");
        //Debug.Log("CountThingsInArrayList() = " + CountThingsInArrayList());
    }

    public static int CountThingsInArrayList() {
        // Used for debugging
        Debug.Log("m_TargetsList.Count = " + m_TargetsList.Count);
        return m_TargetsList.Count;
    }

    public static void IterateThroughArrayList() {

    }

    public static GameObject GetNearestInArrayList() {
        GameObject nearest = m_TargetsList[0];
        float dist = Mathf.Infinity;
        //foreach (GameObject target in m_TargetsList) {
        //    if (target.transform.position.sqrMagnitude < nearest.transform.position.sqrMagnitude) {
        //        nearest = target;
        //        Debug.Log("nearest = " + nearest);
        //    }
        //}
        if (CountThingsInArrayList() == 0)
            return null;
        else {
            for (int i = 0; i < m_TargetsList.Count; i++) {
                if (m_TargetsList[i].activeSelf == false) {
                    continue;
                }

                float distanceBetween = Vector3.Distance(m_TargetsList[i].transform.position, nearest.transform.position);

                if (nearest == null || distanceBetween < dist) {
                    nearest = m_TargetsList[i];
                    dist = distanceBetween;
                }

                if (m_TargetsList[i].transform.position.sqrMagnitude < nearest.transform.position.sqrMagnitude) {
                    nearest = m_TargetsList[i];
                    Debug.Log("nearest = " + nearest);
                }
            }
            return nearest;
        }
    }

}
