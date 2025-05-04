using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _scale = 2f;
    [SerializeField] private int _loop = -1;
    [SerializeField] private LoopType _loopMode = LoopType.Yoyo;
    [SerializeField] private Ease _easeMode = Ease.Linear;

    private void Start()
    {
        transform.DOScale(_scale, _duration)
            .SetLoops(_loop, _loopMode)
            .SetEase(_easeMode);
    }
}
