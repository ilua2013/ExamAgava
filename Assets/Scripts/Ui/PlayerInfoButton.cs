using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoButton : MonoBehaviour
{
    [SerializeField] private Button _infoButton;
    [SerializeField] private GameObject _infoPanel;

    private void OnValidate()
    {
        if(_infoPanel == null)
            throw new System.Exception($"Не назначена панель информации на объекте {gameObject}");
        if(_infoButton == null)
            throw new System.Exception($"Не назначена кнопка объекте {gameObject}");
    }

    private void OnEnable()
    {
        _infoButton.onClick.AddListener(OnInfoButtonClick);
    }

    private void OnDisable()
    {
        _infoButton.onClick.RemoveListener(OnInfoButtonClick);
    }

    private void OnInfoButtonClick()
    {
        _infoPanel.SetActive(true);
    }
}
