using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Test", menuName = "EnemyData/Enemy Data")]
public class Data : EnemyBase
{
    public string enemyName;
    public string enemyType;
    public bool isEnemy;
    public float health=20f;
    public float speed =2f;
    public float detectRadius =10f;
    public int damage = 1;
    public GameObject enemyModel;

    public override void DoMove()
    {
        int numero = 2;
        for (int i = 0; i < numero; i++)
        {
            numero++;
           Debug.Log(numero);
        }
    }
}
