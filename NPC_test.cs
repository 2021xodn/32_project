using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_test : AbstractNPC {
    //static string name;
    private void Start() {
        BEFORE_DIALOG = new string[] {  // 가능하다면 이후 json 파일로 수정
            "이전 대화0",
            "이전 대화1",
            "이전 대화2"
        };
        AFTER_DIALOG = new string[] {  // 가능하다면 이후 json 파일로 수정
            "이후 대화0",
            "이후 대화1",
            "이후 대화2"
        };
    }

}
