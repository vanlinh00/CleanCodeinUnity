using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1 constructor
// 2 StatePattern
// 3 enum
// 4 when you inherit superclass then you can use list like this
public class GameControllerStatePattern : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject creeperObj;
    public GameObject skeletonObj;

    // A list that will hold all enemies

    // 4

    List<EnemyStatePattern> enemies = new List<EnemyStatePattern>();

    private void Start()
    {
        // 4
        enemies.Add(new SkeletonStatePattern(skeletonObj.transform));
        enemies.Add(new CreeperStatePattern(creeperObj.transform));
    }
    private void Update()
    {
        // update all enemies to see if they should change state and move/ attack player
        for (int i = 0; i < enemies.Count; i++)
            enemies[i].UpdateEnemy(playerObj.transform);

    }

}
