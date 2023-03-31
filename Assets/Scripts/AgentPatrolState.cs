using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentPatrolState : AgentBaseState
{
    public override void EnterState(AgentController_FSM theAgent)
    {
        Debug.Log("patrol");
        theAgent.MeshRenderer.material.color = Color.green;
        //theAgent.transform.position = theAgent.patrolPos;
    }

    public override void OnCollisionEnter(AgentController_FSM theAgent)
    {
        
    }

    public override void Update(AgentController_FSM theAgent)
    {

        //Vector3 neighborhood = theAgent.transform.position - theAgent.patrolPos;
        Vector3 neighborhood = theAgent.transform.position - theAgent.myCube.transform.position;
        Debug.Log(neighborhood.magnitude);
        if (neighborhood.magnitude < 1.5f)
        {
            theAgent.TransitionToState(theAgent.AttackState);
        }
        
        theAgent.NavMeshAgent.SetDestination(theAgent.patrolPos);
        //theAgent.TransitionToState(theAgent.PatrolState);

    }
}
