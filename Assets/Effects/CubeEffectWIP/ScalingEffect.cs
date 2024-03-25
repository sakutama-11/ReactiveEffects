using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ScalingEffect : MonoBehaviour
{
    [SerializeField] float _maxScale = 2f;
    [SerializeField] float _duration = 0.1f;

    private Vector3 _baseSize;
    
    
    void Start()
    {
        _baseSize = transform.localScale;
    }

    public void Expand()
    {
        // DOTweenを使って拡大アニメーションを実装
        transform.DOScale(_maxScale * _baseSize, _duration).OnComplete(() =>
        {
            // アニメーションが終わったら元のサイズに戻す
            transform.DOScale(_baseSize, _duration * 0.3f);
        });
    }
}
