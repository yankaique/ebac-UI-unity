using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = .1f;

    private Vector3 _defaultScale;
    private Tween _currentTween;

    private void Awake()
    {
        // pega o tamanho atual
        _defaultScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // aqui ele seta o tamanho da escala e sua duração
        _currentTween = transform.DOScale(_defaultScale * finalScale, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // correção de erro para que o item não fique com a escala ainda maior
        _currentTween.Kill();
        transform.localScale = _defaultScale;
    }
}
