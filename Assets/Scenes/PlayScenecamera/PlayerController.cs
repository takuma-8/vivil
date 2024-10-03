using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float playerspeed = 10f;
    void Update()
    {

        Vector3 position = transform.position;

        position.z += playerspeed * Time.deltaTime;
        // A�L�[��������Ă���ƍ��Ɉړ�
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= 5f * Time.deltaTime; // ���Ɉړ�
        }
        // D�L�[��������Ă���ƉE�Ɉړ�
        if (Input.GetKey(KeyCode.D))
        {
            position.x += 5f * Time.deltaTime; // �E�Ɉړ�
        }
            

        // �V�����ʒu��ݒ�
        transform.position = position;
    }
}


