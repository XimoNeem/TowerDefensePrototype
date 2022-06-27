using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTruck : Truck
{
    public int Health { get; set; }
    public override int TruckHealth { get => Health; set => Health = value; }
    public List<Trooper> Troopers { get; set; }

    void Start()
    {
        
    }
}