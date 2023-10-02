using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.core.Singleton;

namespace Screens
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screenBase;
        public ScreenType startScreen = ScreenType.Panel;
        private ScreenBase _currentScreen;

        private void Start()
        {
            HideAll();
            ShowByType(startScreen);
        }

        private void GetRandom()
        {
            screenBase[Random.Range(0, screenBase.Count)].animationDuration = 1;
        }

        public void ShowByType(ScreenType type)
        {
            if (_currentScreen != null) _currentScreen.Hide();

            var nextScreen = screenBase.Find(i => i.screenType == type);
            nextScreen.Show();
            _currentScreen = nextScreen;
        }

        public void HideAll()
        {
            screenBase.ForEach(i => i.Hide());
        }
    }
}
