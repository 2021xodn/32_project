using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Letter : AbstractNPC {
    private void Start() {            // 각 NPC마다 초기 설정
        DIALOG_BEFORE = new (string, int, string[])[] {
            ("길을 헤메고 있는 거야?", 2, new string[]{ "응", "아니"}),
            ("내가 길을 알려줄 수 있는데!", 2, new string[]{ "어떻게?", "필요 없어"}),
            ("내가 부모님께 쓴 편지를 잃어버렸어...\n찾아주면 내가 길을 알려줄게", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST= new (string, int, string[])[] {
            ("찾고 있는 거지?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR= new (string, int, string[])[] {
            ("정말 찾아올 줄이야! 감동이야...", 0, EMPTY_STRING_ARRAY),
            ("사실 이곳에 오기 전에 부모님께 \n말썽 부렸던 게 너무 후회돼", 0, EMPTY_STRING_ARRAY),
            ("그래서 쓴 편지인데 난 이미 드릴 수가 없어...\n너도 부모님께 편지를 써서 마음을 전달해 봐", 3, new string[]{"응", "아니 안 할래"}),
            ("", 0, EMPTY_STRING_ARRAY)
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("부모님이 정말 감동 받겠다..\n넌 너희 부모님의 정말 소중한 자식이야 항상 힘내!", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("풀 숲에서 편지를 찾았다 !", 0, EMPTY_STRING_ARRAY),
            ("", 0,EMPTY_STRING_ARRAY),
        };

        test = new (string, int, string[])[] {
            ("유니티", 0, new string[]{"", ""}),
            ("로로", 1, new string[]{"도", "레"}),
            ("", 0, new string[]{"", "1"}),
        };

        NPC_NAME = "앨리스";


        hasQuest = true;
        loadMark();
        renderMark();
    }

}
