using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyUIController : UIController
{
    [SerializeField] private LobbyContentItem[] _lobbyContentItems;

    public void SetNewContent(LobbyItemType type)
    {
        foreach (var item in _lobbyContentItems)
        {
            if (item.Item == null) { continue; }
            
            if (item.ItemType == type)
            {
               item.Item.SetActive(true);
            }
            else
            {
                item.Item.SetActive(false);
            }
        }
    }
    
}

[System.Serializable]
struct LobbyContentItem
{
    public LobbyItemType ItemType;
    public GameObject Item;
}