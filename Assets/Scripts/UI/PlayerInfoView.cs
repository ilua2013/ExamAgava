using TMPro;
using UnityEngine;

namespace UI
{
    public class PlayerInfoView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _money;
        [SerializeField] private TMP_Text _health;
        
        public void Initialize(string name, int money, int health)
        {
            _name.text = name;
            _money.text = money.ToString();
            _health.text = health.ToString();
        }
    }
}