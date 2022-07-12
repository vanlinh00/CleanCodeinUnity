using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : singleton<GameController>
{
    //protected override void 
    protected override void Awake()
    {
        base.Awake();
        Debug.Log("hello player");
    }
    public void Test()
    {
        Debug.Log("test ok");
    }
}
