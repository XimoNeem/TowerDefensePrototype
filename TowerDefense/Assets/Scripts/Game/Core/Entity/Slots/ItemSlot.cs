using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game.Core.Entity.Slots
{
    public class ItemSlot : Slot
    {
        private Trooper _currentTrooper;
        private SpriteRenderer _spriteRenderer;
        public override SpriteRenderer SpriteRenderer => _spriteRenderer;
        public override Trooper CurrentTrooper { get => _currentTrooper; set => _currentTrooper = value; }

        public override void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
        public override void SetItem(Trooper trooper)
        {
            _currentTrooper = trooper;
        }
        public override void Show(bool state)
        {
            _spriteRenderer.enabled = state;
        }
    }
}