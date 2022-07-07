using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UIItem_LobbyButton : MonoBehaviour, IUIItem
{
    [SerializeField] private LobbyItemType _type;
    private Button _button;
    [SerializeField] private Color _selectedColor = Color.green;
    [SerializeField] private Color _deselectedColor = Color.white;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Click);
    }

    private void Click()
    {
        FindObjectOfType<LobbyContext>().NavigateToLobbyItem(_type);
        FindObjectOfType<LobbyUIController>().SetNewContent(_type);

        foreach (var item in FindObjectsOfType<UIItem_LobbyButton>())
        {
            item.GetComponent<Button>().targetGraphic.color = _deselectedColor;
        }
        _button.targetGraphic.color = _selectedColor;
    }

    public void SetValue()
    {
        throw new System.NotImplementedException();
    }
}
