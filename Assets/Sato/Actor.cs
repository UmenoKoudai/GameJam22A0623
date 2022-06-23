using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    // ///////////////////////
    /* ���҂̃R���g���[���[ */
    // ///////////////////////

    // 0�ɂȂ��Ă���U������܂ł̃E�F�C�g
    [SerializeField] float _wait;
    [SerializeField] GameObject _stand;
    [SerializeField] GameObject _attacked;
    [SerializeField] bool _isPlayer;

    public delegate void Attack(bool b);
    public Attack _attack;

    void Start()
    {
        StartCoroutine(AutoAction());
    }

    void Update()
    {

    }

    public void Action()
    {
        _attack.Invoke(_isPlayer);
        _stand.SetActive(false);
        _attacked.SetActive(true);
    }

    // �w�肳�ꂽ�b��ɍU������
    IEnumerator AutoAction()
    {
        yield return new WaitForSecondsRealtime(_wait);
        Action();
    }
}
