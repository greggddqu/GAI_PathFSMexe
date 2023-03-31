using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAttackSate : AgentBaseState
{
    public override void EnterState(AgentController_FSM theAgent)
    {
        Debug.Log("attack");
        theAgent.MeshRenderer.material.color = Color.red;
        //theAgent.transform.position = theAgent.fightPos;
    }

    public override void OnCollisionEnter(AgentController_FSM theAgent)
    {
        //theAgent.TransitionToState(theAgent.RetreatState);
    }

    public override void Update(AgentController_FSM theAgent)
    {
        //Vector3 neighborhood = theAgent.transform.position - theAgent.myCube.transform.position;
        Vector3 neighborhood = theAgent.transform.position - theAgent.fightPos;
        //Debug.Log(neighborhood.magnitude);
        if (neighborhood.magnitude < 1.5f )
        {
            theAgent.TransitionToState(theAgent.RetreatState);
        }
        theAgent.NavMeshAgent.SetDestination(theAgent.fightPos);
        //theAgent.NavMeshAgent.SetDestination(theAgent.myCube.transform.position);
    }
}
