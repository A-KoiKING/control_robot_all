using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MoveTitle : MonoBehaviour
{
    public GameObject _1;
    public GameObject _2;
    public GameObject _3;
    public GameObject _4;
    public GameObject _5;
    public GameObject _6;
    public GameObject _7;
    public GameObject _newback;


    // Start is called before the first frame update
    void Start()
    {
        //Sequence�̃C���X�^���X���쐬
        var sequence = DOTween.Sequence();

        //Append�œ����ǉ����Ă���
        sequence.Append(_1.transform.DOMoveX(90f, 2.5f));
        sequence.Join(_2.transform.DOMoveX(90f, 2.5f).SetDelay(0.5f));
        sequence.Join(_3.transform.DOMoveX(90f, 2.5f).SetDelay(0.5f));
        sequence.Join(_4.transform.DOMoveX(90f, 2.5f).SetDelay(0.5f));
        sequence.Join(_5.transform.DOMoveX(90f, 2.5f).SetDelay(0.5f));
        sequence.Join(_6.transform.DOMoveX(90f, 2.5f).SetDelay(0.5f));
        sequence.Join(_7.transform.DOMoveX(90f, 2.5f).SetDelay(0.5f)).OnComplete(() =>
        {
            _newback.SetActive(true);
            _1.SetActive(false);
            _2.SetActive(false);
            _3.SetActive(false);
            _4.SetActive(false);
            _5.SetActive(false);
            _6.SetActive(false);
            _7.SetActive(false);
        });

        //Play�Ŏ��s
        sequence.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
