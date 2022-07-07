using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTruck : Truck
{
    public int Health { get; set; }
    public override int TruckHealth { get => Health; set => Health = value; }
    public List<Trooper> Troopers { get; set; }
    public Slot[] Slots { get; private set; }

    private void Start()
    {
        Slots = GetComponentsInChildren<Slot>();
    }

    public void ShowSlots(bool state)
    {
        foreach (var item in Slots)
        {
            item.Show(state);
        }
    }
}