using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
   public List<Data> enemyList = new List<Data> ();
    private void EnemyMove()
    {
        foreach(Data enemy in enemyList)
        {
            enemy.DoMove();
        }
    }

}
