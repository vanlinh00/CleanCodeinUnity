using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonStatePattern : EnemyStatePattern
{
    EnemyFSM skeletonMode = EnemyFSM.Stroll;
    [SerializeField] float health = 100f;

    public SkeletonStatePattern(Transform skeletonObj)
    {
        base.enemyObj = skeletonObj;
    }

    // update the creeper's state

    // you must code the function with protected because at the parent class it is protected
    public override void UpdateEnemy(Transform playerObj)
    {
        // the distance between the creeper and the player

        float distance = (base.enemyObj.position - playerObj.position).magnitude;
        switch (skeletonMode)
        {
            case EnemyFSM.Attack:
                if (health < 20f)
                {
                    skeletonMode = EnemyFSM.Flee;
                }
                else if (distance > 6f)
                {
                    skeletonMode = EnemyFSM.MoveTowardsPlayer;
                }
                break;
            case EnemyFSM.Stroll:
                if (distance < 10f)
                {
                    skeletonMode = EnemyFSM.MoveTowardsPlayer;
                }
                break;
            case EnemyFSM.MoveTowardsPlayer:
                if (distance < 5f)
                {
                    skeletonMode = EnemyFSM.Attack;
                }
                else if (distance > 15f)
                {
                    skeletonMode = EnemyFSM.Stroll;
                }
                break;
        }
        // move the enemy based on state
        DoAction(playerObj, skeletonMode);

    }
}
