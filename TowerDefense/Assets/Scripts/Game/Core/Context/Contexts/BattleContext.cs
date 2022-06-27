using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BattleContext : GameContext
{
    private BattleUIController _uiController;
    public override UIController UIController { get => _uiController; set => _uiController = (BattleUIController)value; }

    [SerializeField] private Transform _playerPosition;
    [SerializeField] private Transform _enemyPosition;

    [SerializeField] public PlayerTruck PlayerTruck { get; private set; }
    [SerializeField] public EnemyTruck EnemyTruck { get; private set; }

    private void Awake()
    {
        UIController = FindObjectOfType<UIController>();

        PlayerTruck = FindObjectOfType<PlayerTruck>();
        EnemyTruck = FindObjectOfType<EnemyTruck>();
    }

    private void Start()
    {
        PlayerTruck.transform.position = _playerPosition.position;
        EnemyTruck.transform.position = _enemyPosition.position;

        _uiController.SetPlayerHealth(PlayerTruck.Health, 900);
        _uiController.SetEnemyHealth(EnemyTruck.Health, 900);
    }

    public void LoadLobbyContext()
    {
        SceneManager.LoadScene("Main");
    }
}