using UnityEngine.UI;
using UnityEngine;

public class MoneySaver : MonoBehaviour
{
    [SerializeField] private Button _saveButton;

    private void OnValidate()
    {
        if (_saveButton == null)
            throw new System.Exception($"Не назначена кнопка сохранения денег на объекте {gameObject}");
    }

    private void OnEnable()
    {
        _saveButton.onClick.AddListener(SaveMoney);
    }

    private void OnDisable()
    {
        _saveButton.onClick.RemoveListener(SaveMoney);
    }

    private void SaveMoney()
    {
        //Send on server
    }

}
