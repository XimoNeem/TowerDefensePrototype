using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTruck : Truck
{
    public int Health { get; set; }
    public override int TruckHealth { get => Health; set => Health = value; }
    public List<Trooper> Troopers { get; set; }

    private void Start()
    {
        
    }
}
