using DG.Tweening;
using UnityEngine;
//DoTween을 사용하기 위해 선언

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;
    Sequence sequenceLoop;

    void Start()
    {

        /*transform.DOMoveX(5, 2);
        //x축으로 2초동안 5만큼 이동
        transform.DORotate(new Vector3(0, 0, 180), 2);
        //z축으로 2초동안 180도 회전
        transform.DOScale(new Vector3(2, 2, 2), 2);
        //크기를 2초동안 2,2,2로 확장*/

        /*Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2).OnComplete(SecuenceEnd));*/

        /*sequenceLoop = DOTween.Sequence();
        sequenceLoop.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        sequenceLoop.SetLoops(-1, LoopType.Yoyo);*/

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sequenceLoop.Kill();
            if (!isPunch)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);
            }
        }
    }

    void SecuenceEnd()
    {
        gameObject.SetActive(false);
    }

    void EndPunch()
    {
        isPunch = false;
    }

}
