using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{

    public float curValue; //���� ��
    public float startValue;
    public float maxValue; //�ִ�
    public float passiveValue;
    public Image uiBar; //using UnityEngine.UI;

    // Start is called before the first frame update
    void Start()
    {
        curValue = startValue; //���������� ���� ��.
    }

    // Update is called once per frame
    void Update()
    {
        //ui ������Ʈ
        uiBar.fillAmount = GetPercentage(); //���� ü���� ���ؼ� ui�ٸ� ä�쵵�� ���ִ� �ڵ�. fillAmount�� �ִ��� 1.
    }

    float GetPercentage() // ���� ü���� ���ϴ�.
    {
        return curValue / maxValue;
    }

    public void Add(float value)//������ ������Ʈ ���� ��. �ܺο��� add�� ȣ���Ͽ� ��� curValue ����.
    {
        curValue = Mathf.Min(curValue + value, maxValue); //�ΰ��� �Ű������� �޾Ƽ� �� ���� ���� �־���.
    }

    public void Subtract(float value) //������ ������Ʈ. curValue ����.
    {
        curValue = Mathf.Max(curValue - value, 0); //���� �ݴ�� �����ϸ� ��.
    }
}
