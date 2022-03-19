using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Mirror : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // 가능하다면 이후 json 파일로 수정
            ("안돼 안돼!", 1, new string[]{ "무슨 일이야?", "놀랐잖아 ! 조심해줘"}),
            ("중요한 물건을 잃어버렸어.", 1, new string[]{ "그게 뭔데?", "어떤거?"}),
            ("마음의 거울이라고 \n내가 제일 아끼는 거울이야.", 1, new string[]{ "거울에 마음이 보여?", "마음의 거울이라..."}),
            ("자신이 제일 사랑하는 사람을 비춰줘,\n나좀 도와줄래?", 0, EMPTY_STRING_ARRAY),
            ("내 거울 좀 찾아줄 수 있을까?", 2, new string[]{"응!", "아니"}),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("거울을 찾아서 나에게 가져다 줘...", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("찾았구나..! 넌 최고야. \n이 거울로 너도 마음을 확인해볼래?", 1, new string[]{ "어? 왜 내가 비춰지지?", "이거 그냥 거울 아니야?"}),
            ("이 거울은 자신이 가장 사랑하는 사람을 비춰줘, \n아마 너의 내면에선 너를 가장 사랑하고 있는 거야 ", 1, new string[]{ "정말?", "그래?"}),
            ("그럼 ~ 자신을 사랑하는 모습만큼 멋진 건 없을 거야. \n혹시 다른 사람의 마음들도 확인해보고 싶니?", 1, new string[]{"응", "완전!!"}),
            ("확인해보고 싶은 사람에게 이 거울을 전달해줘", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("그 사람 마음은 확인해봤니?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("거울을 찾았다.", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "신디";

        hasQuest = true;
        loadMark();
        renderMark();
    }

}
