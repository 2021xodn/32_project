using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float moveSpeed = 20.0f; // 캐릭터 이동 속도

    public bool isDialog = false;   // 대화 중인지
    public bool isDialogDelay = false;  // 대화 도중 딜레이 (막 넘길 수 없게)
    string[] DIALOG;
    int DIALOG_LEN;
    int dialog_now = 0;
    
    public Player_area area;    // 플레이어 주변 인식

    void Start() {
    }

    void Update() {
        if (!isDialog) {    // 대화 시 이동 봉인  방향키 상하좌우 + 스페이스키로 대화 하게 설정함. 일단
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
            //Debug.Log("Player_move | 스페이스 입력");
            if (!isDialog && !isDialogDelay) {    // 대화중이 아니고, 대화 딜레이가 안 걸려 있을 때. 대화에 진입
                isDialogDelay = true;
                isDialog = true;                                                                // '근처에 NPC가 있는 지' 라는 조건은 아직 넣지 않았음
                DIALOG = area.getRecognizedNPC().GetComponent<NPC_test>().getBeforeDialog();    // 근처에 있는 해당 NPC의 대화 문자열을 가져옴
                DIALOG_LEN = DIALOG.Length;
                dialog_now = 0;                                                                 // 현재 페이지 초기화
                StartCoroutine(DialogDelay("Player_move DialogStartDelay | 딜레이 종료", 1));
            }else{
                if (dialog_now < DIALOG_LEN && !isDialogDelay) {                                // 모든 대화를 읽어야 종료
                    isDialogDelay = true;
                    Debug.Log(DIALOG[dialog_now]);                                                // 이후 gui로 뿌릴 대화 텍스트 (일단 콘솔창에)
                    StartCoroutine(DialogDelay("Player_move DialogDelay | "+ dialog_now +"번 째 대화 종료", 1));
                    dialog_now++;
                    if (dialog_now >= DIALOG_LEN) {
                        isDialog = false;
                        Debug.Log("Player_move 대화 종료");
                        Debug.Log(isDialog);
                    }
                }
                
            }
            
        }
    }

    IEnumerator DialogDelay(string text, float delayTime) { // 대화 도중 딜레이
        yield return new WaitForSeconds(1f * delayTime); // 2초 대기
        isDialogDelay = false;
        Debug.Log(text);
    }
}
