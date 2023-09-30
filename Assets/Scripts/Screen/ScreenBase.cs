using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        public ScreenType ScreenType;
        public List<Transform> listOfObjects;
        public bool startHide = false;

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
        protected virtual void Show()
        {
            ShowObjects();
        } 
        
        protected virtual void Hide()
        {
            HideObjects();
        }

        [Button]
        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
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
        }
    
    }
}

