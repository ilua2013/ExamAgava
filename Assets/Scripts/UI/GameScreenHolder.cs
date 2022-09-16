using UnityEngine;

namespace UI
{
    public class GameScreenHolder : MonoBehaviour
    {
        [SerializeField] private ShowInfoScreen _showInfoScreen;

        private void Start()
        {
            _showInfoScreen.Close();
        }

        private void OnEnable()
        {
            _showInfoScreen.ShowInfoButtonClick += OnShowInfoButtonClick;
        }

        private void OnDisable()
        {
            _showInfoScreen.ShowInfoButtonClick -= OnShowInfoButtonClick;
        }

        private void OnShowInfoButtonClick()
        {
            _showInfoScreen.Open();
        }
    }
}