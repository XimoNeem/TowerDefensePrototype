using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LobbyContext : GameContext
{
    private UIController _uiController;
    public override UIController UIController { get => _uiController; set => _uiController = value; }

    [SerializeField] private List<LobbyItem> _lobbyItems = new List<LobbyItem>();
    private CameraController _cameraController;
    private void Awake()
    {
        UIController = FindObjectOfType<UIController>();
    }
    private void Start()
    {
        _cameraController = FindObjectOfType<CameraController>();
        NavigateToLobbyItem(LobbyItemType.Main);
    }

    public void LoadButtleContext()
    {
        SceneManager.LoadScene("Battle");
    }

    /// <summary>
    /// Перемещает к нужному участку лобби
    /// </summary>
    /// <param lobbyItemType="type"></param>
    public void NavigateToLobbyItem(LobbyItemType type)
    {
        _cameraController.MoveCamera(FindLobbyItemOfType(type).Item.transform.position);
    }
    private LobbyItem FindLobbyItemOfType(LobbyItemType type)
    {
        foreach (var item in _lobbyItems)
        {
            if (item.Type == type)
            {
                return item;
            }
        }
        return null;
    }
}

[System.Serializable]
public class LobbyItem
{
    public GameObject Item;
    public LobbyItemType Type;
    public LobbyItem(GameObject item)
    {
        Item = item;
    }
}

[System.Serializable]
public enum LobbyItemType
{
    Base,
    Map,
    Vehicle,
    Main
}