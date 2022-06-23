using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // /////////////////////////
    /* �G����̃R���g���[���[ */
    // /////////////////////////

    // 0�ɂȂ��Ă���U������܂ł̃E�F�C�g
    [SerializeField] float _wait;

    public delegate void Attack(bool b);
    public Attack _attack;

    void Start()
    {
        StartCoroutine(Action());
    }

    void Update()
    {
        
    }

    // �w�肳�ꂽ�b��ɍU������
    IEnumerator Action()
    {
        yield return new WaitForSecondsRealtime(_wait);
        _attack.Invoke(false);
    }
}
