using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float moveSpeed = 20.0f; // ĳ���� �̵� �ӵ�

    public bool isDialog = false;   // ��ȭ ������
    public bool isDialogDelay = false;  // ��ȭ ���� ������ (�� �ѱ� �� ����)
    string[] DIALOG;
    int DIALOG_LEN;
    int dialog_now = 0;
    
    public Player_area area;    // �÷��̾� �ֺ� �ν�

    void Start() {
    }

    void Update() {
        if (!isDialog) {    // ��ȭ �� �̵� ����  ����Ű �����¿� + �����̽�Ű�� ��ȭ �ϰ� ������. �ϴ�
            if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow)) {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow)) {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.Space)) {
            //Debug.Log("Player_move | �����̽� �Է�");
            if (!isDialog && !isDialogDelay) {    // ��ȭ���� �ƴϰ�, ��ȭ �����̰� �� �ɷ� ���� ��. ��ȭ�� ����
                isDialogDelay = true;
                isDialog = true;                                                                // '��ó�� NPC�� �ִ� ��' ��� ������ ���� ���� �ʾ���
                DIALOG = area.getRecognizedNPC().GetComponent<NPC_test>().getBeforeDialog();    // ��ó�� �ִ� �ش� NPC�� ��ȭ ���ڿ��� ������
                DIALOG_LEN = DIALOG.Length;
                dialog_now = 0;                                                                 // ���� ������ �ʱ�ȭ
                StartCoroutine(DialogDelay("Player_move DialogStartDelay | ������ ����", 1));
            }else{
                if (dialog_now < DIALOG_LEN && !isDialogDelay) {                                // ��� ��ȭ�� �о�� ����
                    isDialogDelay = true;
                    Debug.Log(DIALOG[dialog_now]);                                                // ���� gui�� �Ѹ� ��ȭ �ؽ�Ʈ (�ϴ� �ܼ�â��)
                    StartCoroutine(DialogDelay("Player_move DialogDelay | "+ dialog_now +"�� ° ��ȭ ����", 1));
                    dialog_now++;
                    if (dialog_now >= DIALOG_LEN) {
                        isDialog = false;
                        Debug.Log("Player_move ��ȭ ����");
                        Debug.Log(isDialog);
                    }
                }
                
            }
            
        }
    }

    IEnumerator DialogDelay(string text, float delayTime) { // ��ȭ ���� ������
        yield return new WaitForSeconds(1f * delayTime); // 2�� ���
        isDialogDelay = false;
        Debug.Log(text);
    }
}
