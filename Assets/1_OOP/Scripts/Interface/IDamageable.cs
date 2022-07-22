using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// 01.... 1 object implement 1 interface

//public interface IDamageable 
//{
//    void Damage(float damgeAmount);
//}


// 02.....1 interface can implement another interface
public interface IDamageable : IAbcable
{
    void Damage(float damgeAmount);
}
public interface IAbcable
{
    void Abc(int abc);
}


// 3..... 1 class can implement 2 interface or multiple  interface