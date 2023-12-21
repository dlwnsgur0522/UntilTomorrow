using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �̱������� ����� ��� MonoBehavior �κ��� ����� Singleton<Ŭ������> ���ָ� ��
// Singleton�̶�� ���� ������ Generic���� ���� ��ũ��Ʈ�� �̸��� Singleton�̱� ����
public class DataManager : Singleton<DataManager>
{
    public float stageNum;
    public int killCount;

    public string[] formation = new string[3];

    private void Start()
    {
        Time.timeScale = 1f;
    }
}
