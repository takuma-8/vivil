using UnityEngine;

public class LineTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // �v���C���[�̃^�O���m�F
        if (other.CompareTag("Player"))
        {
            // �v���C���[���G�ꂽ���̏���
            Debug.Log("�v���C���[�����C���ɐG��܂����B");
            

            // ���̏����������ɒǉ�
        }
    }
}