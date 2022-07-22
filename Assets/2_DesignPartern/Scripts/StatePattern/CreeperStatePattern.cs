using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the skeleton class
public class CreeperStatePattern : EnemyStatePattern
{
    EnemyFSM creeperMode = EnemyFSM.Stroll;

    float health = 100f;

    // constructor
    public CreeperStatePattern(Transform skeletonObj)
    {
        base.enemyObj = skeletonObj;
    }

    // Update the creeper's state
    public override void UpdateEnemy(Transform playerObj)
    {
        // the distance between the creeper and the player
        float distance = (base.enemyObj.position - playerObj.position).magnitude;

        switch (creeperMode)
        {
            case EnemyFSM.Attack:
                if (health < 20f)
                {
                    creeperMode = EnemyFSM.Flee;
                }
                else if (distance > 2f)
                {
                    creeperMode = EnemyFSM.MoveTowardsPlayer;
                }
                break;
            case EnemyFSM.Flee:
                if (health > 60f)
                {
                    creeperMode = EnemyFSM.Stroll;
                }
                break;
            case EnemyFSM.Stroll:
                if (distance < 10f)
                {
                    creeperMode = EnemyFSM.MoveTowardsPlayer;
                }
                break;
            case EnemyFSM.MoveTowardsPlayer:
                if (distance < 1f)
                {
                    creeperMode = EnemyFSM.Attack;
                }
                else if (distance > 15f)
                {
                    creeperMode = EnemyFSM.Stroll;
                }
                break;

        }

        // Move the enemy base on a state
        DoAction(playerObj, creeperMode);

    }
}


