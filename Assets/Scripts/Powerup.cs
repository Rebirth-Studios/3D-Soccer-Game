using System;
using DG.Tweening;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Action OnDeath;

    private void Start()
    {
        transform.DORotate(new Vector3(0,360,0), 2, RotateMode.WorldAxisAdd).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        var t = transform.DOMove(transform.position + Vector3.up/2, .75f);
        t.OnComplete(() => transform.DOMove(transform.position + Vector3.down/2, 1.5f, false).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine));
    }

    private void OnDestroy()
    {
        OnDeath?.Invoke();
    }
}