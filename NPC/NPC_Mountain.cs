using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Mountain : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // 가능하다면 이후 json 파일로 수정
            ("안녕? 너 혹시 저기까지 올라갈 수 있어?", 2, new string[]{ "응? 그럼!", "갑자기..?\n 아니.. 못해"}),
            ("난 올라갈 수가 없거든", 0, EMPTY_STRING_ARRAY),
            ("나 대신 한 번 올라가주지 않을래?", 2, new string[]{ "재밌어보이는데?", "미안.."}),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("내 오른쪽에 보이는 저기까지 한 번 올라가주지 않을래?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("너 정말 잘 올라간다", 0, EMPTY_STRING_ARRAY),
            ("나도 부모님한테 건강한 모습을 많이 보이고 싶었어.. \n항상 아팠거든", 1, new string[]{ "아...", "힘들었겠다"}),
            ("너도 어서 돌아가서 부모님께 건강한 모습 보여드려", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("그때는 고생했어", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("끝에 도달했다", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "케빈";

        hasQuest = true;
        loadMark();
        renderMark();
    }

}
