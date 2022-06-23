using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    // /////////////////////////////////
    /* �Q�[���{�҂̃V�[���}�l�[�W���[ */
    // /////////////////////////////////

    [SerializeField] Enemy _enemy;
    [SerializeField] GameObject _attackButton;
    [SerializeField] CountText _countText;
    // �U�����\�ɂȂ�܂ł̃J�E���g
    [SerializeField] int _count;
    // �T�E���h�}�l�[�W���[
    SoundManager soundManager;

    void Awake()
    {
        soundManager = GetComponent<SoundManager>();
    }

    void Start()
    {
        soundManager.Play("SE_�Ă���[��");
        _enemy._attack = Attack;
        _countText.SetCount(_count);
        StartCoroutine(Timer());
    }

    void Update()
    {

    }

    // �Q�[���J�n����J�E���g���n�߂�
    IEnumerator Timer()
    {
        for (int i = _count - 1; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1.0f);
            _countText.SetCount(i);
        }
        _attackButton.SetActive(true);
        _enemy.enabled = true;
    }

    // �U��
    public void Attack(bool isPlayer)
    {
        (string, string) str = isPlayer == true ? ("green", "Player") : ("red", "Enemy");
        Debug.Log($"<color={str.Item1}>{str.Item2}���U������</color>");
        soundManager.Play("SE_�a��");
    }
}
