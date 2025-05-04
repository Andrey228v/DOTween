using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private Transform _pointToMove;
    [SerializeField] private int _loop = -1;
    [SerializeField] private LoopType _loopMode = LoopType.Yoyo;
    [SerializeField] private Ease _easeMode = Ease.Linear;

    private void Start()
    {
        transform.DOMove(_pointToMove.position, _duration)
            .SetLoops(_loop, _loopMode)
            .SetEase(_easeMode);
    }
}
