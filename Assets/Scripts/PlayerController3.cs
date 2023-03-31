using UnityEngine;
using UnityEngine.AI;

public class PlayerController3 : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject myCube;
    Vector3 myCubePos;

    // Update is called once per frame
    void Update()
    {
        myCubePos = myCube.transform.position;
        agent.SetDestination(myCubePos);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    Debug.Log("ray.origin " + ray.origin + " ray.direction " + ray.direction);
        //    Debug.DrawRay(ray.origin,ray.direction,Color.red);
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        Debug.Log(hit.point);
        //        agent.SetDestination(hit.point);
        //    }
        //}
    }
}