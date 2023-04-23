using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    [SerializeField]
    float _speed = 300.0f;

    [SerializeField]
    float _timeup = 5f;

    [SerializeField]
    float _tt = 5f;

    void Update()
    {

        Quaternion originalRotation = this.transform.rotation; // �������� ������� ������� �������
        float rotationZ = originalRotation.eulerAngles.z; // �������� �������� �������� �� ��� z � ��������
        if (rotationZ < 315f && rotationZ > 45f || rotationZ > -45f && rotationZ < -135f)
        {
            this.transform.rotation = originalRotation; // ���������� ������ � �������� ���������
        }
        else
        {
            // ���� �������� �������� ��������� � ������ ���������, �� ��������� ����� �������
            Quaternion newRotation = Quaternion.Euler(originalRotation.eulerAngles.x, originalRotation.eulerAngles.y, Mathf.Clamp(rotationZ, -45f, 45f));
            this.transform.rotation = newRotation; // ��������� ����� ������� � �������
        }



    }

}

