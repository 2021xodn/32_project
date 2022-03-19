using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Picture : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // 가능하다면 이후 json 파일로 수정
            (". . .", 1, new string[]{"뭐해?", "안녕"}),
            ("혹시 내 사진 못 봤니?", 2, new string[]{ "내가 찾아줄까?", "잘 찾아봐"}),
            ("그럼 너무 고맙지... \n꼭 찾아줘..", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("찾고 있어?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("정말 고마워 !!", 0, EMPTY_STRING_ARRAY),
            ("사실 살아있을 때, 그 사람과의 유일한 추억이거든", 1, new string[]{"그렇구나...", "안타깝다..."}),
            ("이걸 줄 테니까 넌 소중한 사람과의 추억을 많이 남겨놔", 0, EMPTY_STRING_ARRAY),
            ("난 이제 필요 없으니까", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("사진, 찾아줘서 고마워", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("사진을 찾았다.", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "레이나";
        hasQuest = true;
        loadMark();
        renderMark();
    }

}
