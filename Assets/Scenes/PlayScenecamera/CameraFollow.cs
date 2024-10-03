using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Player�I�u�W�F�N�g��Transform
    public float fixedX = 0f; // �Œ肷��X�ʒu
    public float offsetY = 5f; // �v���C���[����̍����I�t�Z�b�g
    public float distanceZ = -10f; // �v���C���[�����Z�����I�t�Z�b�g

    public GameObject speedEffect; // ���x�G�t�F�N�g�̃v���n�u
    public float speedThreshold = 15f; // �G�t�F�N�g��\�����鑬�x��臒l
    private bool isEffectActive = false; // �G�t�F�N�g���\������Ă��邩�ǂ���

    private Vector3 previousPosition; // �v���C���[�̑O��̈ʒu���L�^

    void Start()
    {
        // �v���C���[�̏����ʒu���L�^
        previousPosition = player.position;

        // �G�t�F�N�g����U��\���ɂ���
        speedEffect.SetActive(false);
    }

    void LateUpdate()
    {
        if (player != null) // �v���C���[���ݒ肳��Ă��邩�m�F
        {
            // �J�����̈ʒu���v���C���[��Z�ʒu�Ɋ�Â��čX�V
            transform.position = new Vector3(fixedX, player.position.y + offsetY, player.position.z + distanceZ);

            // �v���C���[�̑��x���v�Z (�t���[���Ԃ̈ړ�����/����)
            float playerSpeed = (player.position - previousPosition).magnitude / Time.deltaTime;

            // �X�s�[�h��30f�𒴂����ꍇ�ɃG�t�F�N�g��L����
            if (playerSpeed > speedThreshold && !isEffectActive)
            {
                speedEffect.SetActive(true); // �G�t�F�N�g��\��
                isEffectActive = true;
            }
            // �X�s�[�h��30f�ȉ��ɂȂ�����G�t�F�N�g���\���ɂ���
            else if (playerSpeed <= speedThreshold && isEffectActive)
            {
                speedEffect.SetActive(false); // �G�t�F�N�g���\��
                isEffectActive = false;
            }

            // ���݂̃v���C���[�̈ʒu�����̃t���[���p�ɕۑ�
            previousPosition = player.position;
        }
    }
}
