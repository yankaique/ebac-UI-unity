using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
using DG.Tweening;

namespace Screens
{
    public enum ScreenType
    {
        Panel,
        Info_Panel,
        Shop
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;
        public List<Transform> listOfObjects;
        public List<TextTypper> listOfPhrases;
        public bool startHide = false;

        public Image uiBackground;

        [Header("Animations")]
        public float delayBetweenObjects = .05f;
        public float animationDuration = .3f;

        private void Start()
        {
            if(startHide)
            {
                HideObjects();
            }
        }

        [Button]
        public void Show()
        {
            ShowObjects();
        } 
        
        public void Hide()
        {
            HideObjects();
        }

        [Button]
        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
            ShowUI();
        }

        private void ShowObjects()
        {
            //listOfObjects.ForEach(i => i.gameObject.SetActive(true));
            for(int t = 0; t < listOfObjects.Count; t++)
            {
                var obj = listOfObjects[t];

                obj.gameObject.SetActive(true);
                obj.DOScale(0, animationDuration).From().SetDelay(t * delayBetweenObjects);
            }

            Invoke("StartType", delayBetweenObjects * listOfObjects.Count);
            ShowUI(true);
        } 
        
        private void ShowUI(bool show = false)
        {
            if (uiBackground != null)
            {
                uiBackground.enabled = show;
            }
        }

        private void StartType()
        {
            if (listOfPhrases != null)
            {
                for(int t = 0; t < listOfPhrases.Count; t++)
                {
                    listOfPhrases[t].StartType();
                }
            }
        }
    
    }
}

