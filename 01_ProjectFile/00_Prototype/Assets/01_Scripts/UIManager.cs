using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //�� ���� ��ɵ��� ����ϱ� ���� �ʿ���

public class UIManager : MonoBehaviour
{
    // 0. �������� Ȱ��
    public void GoMainScene()
    {
        SceneManager.LoadScene("Mainscene");
    }

    // 1. ���� ������ Ȱ��
    public void GoStageScene()
    {
        SceneManager.LoadScene("StageScene");
        //SceneManager.LoadScene(); ��ȣ ���� ����� ���� ��Ī�� ���� �ҷ����ڴٴ� �ǹ�
    }

    // 2. ĳ���� �� ������ Ȱ��
    

    // 3. �������� ���� ������ Ȱ��
    public void Battle1_1()
    {
        DataManager.Instance.stageNum = 1.1f;
        SceneManager.LoadScene("BattleScene");
    }

    public void Battle1_2()
    {
        DataManager.Instance.stageNum = 1.2f;
        SceneManager.LoadScene("BattleScene");
    }
}
