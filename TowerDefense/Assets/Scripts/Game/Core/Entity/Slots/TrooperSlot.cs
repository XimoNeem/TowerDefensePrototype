using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game.Core.Entity.Slots
{
    public class TrooperSlot : Slot
    {
        private SpriteRenderer _spriteRenderer;
        public override SpriteRenderer SpriteRenderer => _spriteRenderer;
        public override Trooper CurrentTrooper { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
        public override void SetItem(Trooper trooper)
        {

        }
        public override void Show(bool state)
        {
            _spriteRenderer.enabled = state;
        }
    }
}