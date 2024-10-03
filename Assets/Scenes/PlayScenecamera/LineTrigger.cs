using UnityEngine;

public class LineTrigger : MonoBehaviour
{
    // �v���C���[�R���g���[���[�̎Q��
    private PlayerController playerController;

    private void Start()
    {
        // �v���C���[�R���g���[���[���擾
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // �v���C���[�̃^�O���m�F
        if (other.CompareTag("Player"))
        {
            // �v���C���[���G�ꂽ���̏���
            Debug.Log("�v���C���[�����C���ɐG��܂����B");

            // �v���C���[�̑��x���擾���đ���������
            if (playerController != null)
            {
                playerController.playerspeed += 30f; // ���x�𑝉��i5f�͔C�ӂ̑����l�j
                Debug.Log("�V�����v���C���[���x: " + playerController.playerspeed);
            }

            // ���̏����������ɒǉ�
        }
    }
}
