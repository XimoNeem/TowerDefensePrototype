using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public abstract class Enemy : MonoBehaviour
{
    public abstract EnemyBehaviour Behaviour();
}
