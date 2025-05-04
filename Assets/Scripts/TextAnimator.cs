using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimator : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _newText = "fawfawfa1241f12f21214";
    [SerializeField] private float _duration = 1f;
    [SerializeField] private bool _isRelative = false;
    [SerializeField] private bool _isRichTextEnabled = true;
    [SerializeField] private ScrambleMode _scrambleMode = ScrambleMode.None;

    private void Start()
    {
        Tween tween = _text.DOText(_newText, _duration, _isRichTextEnabled, _scrambleMode);

        if (_isRelative)
        {
            tween.SetRelative();
        }
    }
}
