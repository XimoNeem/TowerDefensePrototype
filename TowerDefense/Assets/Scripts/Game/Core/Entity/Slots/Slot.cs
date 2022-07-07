using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class Slot : MonoBehaviour
{
    public abstract Trooper CurrentTrooper { get; set; }
    public abstract SpriteRenderer SpriteRenderer { get; }

    public abstract void Start();
    public abstract void SetItem(Trooper trooper);
    public abstract void Show(bool state);
}
