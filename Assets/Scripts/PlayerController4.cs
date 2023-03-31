using UnityEngine;
using UnityEngine.AI;

public class PlayerController4 : MonoBehaviour
{

    public NavMeshAgent agent;
    public NavMeshAgent myAgent2;
    public GameObject myCube;
    Vector3 myCubePos;
    
    // Update is called once per frame
    void Update()
    {
        myCubePos = myCube.transform.position;
        agent.SetDestination(myCubePos);
        myAgent2.SetDestination(agent.transform.position);
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