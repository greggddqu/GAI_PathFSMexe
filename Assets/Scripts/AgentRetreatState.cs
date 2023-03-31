using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentRetreatSate : AgentBaseState
{
    public override void EnterState(AgentController_FSM theAgent)
    {
        Debug.Log("retreat");
        theAgent.MeshRenderer.material.color = Color.yellow;
        //theAgent.transform.position = theAgent.safePos;
    }

    public override void OnCollisionEnter(AgentController_FSM theAgent)
    {
        
    }

    public override void Update(AgentController_FSM theAgent)
    {
        Vector3 neighborhood = theAgent.transform.position - theAgent.safePos;
        if (neighborhood.magnitude < 1.5f)
        {
            theAgent.TransitionToState(theAgent.PatrolState);
        }
        theAgent.NavMeshAgent.SetDestination(theAgent.safePos);
    }
}
