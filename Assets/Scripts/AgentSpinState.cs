using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpinState : AgentBaseState
{
    private float rotation = 0;

    public override void EnterState(AgentController_FSM player)
    {
        
    }

    public override void OnCollisionEnter(AgentController_FSM player)
    {
        player.transform.rotation = Quaternion.identity;
        player.TransitionToState(player.PatrolState);
    }

    public override void Update(AgentController_FSM player)
    {
        float amountToRotate = 900 * Time.deltaTime;

        rotation += amountToRotate;

        if (rotation < 360)
        {
            player.transform.Rotate(Vector3.up, amountToRotate);
        }
        else
        {
            player.transform.rotation = Quaternion.identity;
            player.TransitionToState(player.RetreatState);
        }
    }
}
