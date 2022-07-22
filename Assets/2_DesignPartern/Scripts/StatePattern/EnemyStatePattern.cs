using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatePattern : MonoBehaviour
{
    protected Transform enemyObj;

    protected enum EnemyFSM
    {
        Attack,
        Flee,
        Stroll,
        MoveTowardsPlayer,
    }
    public virtual void UpdateEnemy(Transform playerObj)
    {

    }

    // Do something based on a state
    protected void DoAction(Transform playerObj, EnemyFSM enemyMode)
    {
        float fleeSpeed = 10f;
        float strollSpeed = 1f;
        float attackSpeed = 5f;

        switch (enemyMode)
        {
            case EnemyFSM.Attack:
                //Attack player
                Debug.Log("Enemy are attacking the player");
                break;
            case EnemyFSM.Flee:

                // Move away from player
                // Look in the opposite direction

                enemyObj.rotation = Quaternion.LookRotation(enemyObj.position - playerObj.position);

                // Move
                enemyObj.Translate(enemyObj.forward * fleeSpeed * Time.deltaTime);
                break;

            case EnemyFSM.Stroll:
                // Look at a random position
                Vector3 randomPos = new Vector3(Random.Range(0f, 100f), 0f, Random.Range(0f, 100f));

                enemyObj.rotation = Quaternion.LookRotation(enemyObj.position - randomPos);
                // Move
                enemyObj.Translate(enemyObj.forward * strollSpeed * Time.deltaTime);

                break;
            case EnemyFSM.MoveTowardsPlayer:

                // Look at the player
                enemyObj.rotation = Quaternion.LookRotation(playerObj.position - enemyObj.position);

                // Move
                enemyObj.Translate(enemyObj.forward * attackSpeed * Time.deltaTime);
                break;
        }
    }

}
