using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleUIController : UIController
{
    [SerializeField] Slider _playerHealthSlider;
    [SerializeField] TMP_Text _playerHealthText;
    [SerializeField] Slider _enemyHealthSlider;
    [SerializeField] TMP_Text _enemyHealthText;

    /// <summary>
    /// «адать значени€ слайдера здоровь€ дл€ игрока
    /// </summary>
    /// <param currentHealth="currentHealth"></param>
    /// <param maxHealth="maxHealth"></param>
    public void SetPlayerHealth(int currentHealth, int maxHealth)
    {
        _playerHealthSlider.maxValue = maxHealth;
        _playerHealthSlider.value = currentHealth;
        _playerHealthText.text = currentHealth.ToString();
    }

    /// <summary>
    /// «адать значени€ слайдера здоровь€ дл€ противника
    /// </summary>
    /// <param currentHealth="currentHealth"></param>
    /// <param maxHealth="maxHealth"></param>
    public void SetEnemyHealth(int currentHealth, int maxHealth)
    {
        _enemyHealthSlider.maxValue = maxHealth;
        _enemyHealthSlider.value = currentHealth;
        _enemyHealthText.text = currentHealth.ToString();
    }
}
