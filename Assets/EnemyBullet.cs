using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //�������������I�u�W�F�N�g�̃^�O��player or playerBody��������
        //if (other.gameObject.tag == "Player" || other.gameObject.tag == "PlayerBody")
        //{
        //    //���������ł�����
        //    Destroy(this.gameObject);
        //}
    }
    //�e�̃X�s�[�h
    public float speed = 1;
    //���R���ł܂ł̃^�C�}�[
    public float time = 2;
    //�i�s����
    protected Vector3 forward =
        new Vector3(0, 0, 1);
    //�ł��o���Ƃ��̊p�x
    protected Quaternion forwardAxis =
    Quaternion.identity;

    //Rigidbody�p�ϐ�
    protected Rigidbody rd;

    //Enemy�p�ϐ�
    protected GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody�ϐ���������
        rd = this.GetComponent<Rigidbody>();
        //�������ɐi�s���������߂�
        if(enemy != null)
        {
           forward = enemy.transform.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ��ʂ�i�s�����ɃX�s�[�h������������
        rd.velocity = forwardAxis * forward * speed;

        //�󒆂ɕ����Ȃ��悤�ɂ���
        rd.velocity = new Vector3(rd.velocity.x, 0, rd.velocity.z);

        //���Ԑ����������玩�R���ł���
        time -= Time.deltaTime;

        if(time <=0)
        {
            Destroy(this.gameObject);
        }
    }
    //�e��ł��o�����L�����N�^�[�̏���n���֐�
    public void SetCharacterObject(GameObject character)
    {
        //�e��ł��o�����L�����N�^�[�̏����󂯎��
        this.enemy = character;
    }
    //�ł��o���p�x�����肷�邽�߂̊֐�
    public void SetForwardAxis(Quaternion axis)
    {
        //�ݒ肳�ꂽ�p�x���󂯎��
        this.forwardAxis = axis;
    }
}
