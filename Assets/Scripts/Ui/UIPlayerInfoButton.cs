using UnityEngine;
using UnityEngine.UI;

public class UIPlayerInfoButton : MonoBehaviour
{
    [SerializeField] private Button _infoButton;
    [SerializeField] private GameObject _infoPanel;

    private void OnValidate()
    {
        if(_infoPanel == null)
            _infoPanel = FindObjectOfType<UIPlayersInfo>().gameObject;
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
        if (_infoPanel.activeSelf == true)
            _infoPanel.SetActive(false);
        else
            _infoPanel.SetActive(true);
    }
}
