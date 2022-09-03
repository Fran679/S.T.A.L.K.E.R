using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Animals",menuName ="Animal") ]
public class EnemisData : ScriptableObject
{
    public new string name;
    public float damage;
    public float speed;
    public float health;
    public bool isEnemy;
    public float detectionRadius;



}
