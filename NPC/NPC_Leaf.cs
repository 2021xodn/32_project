using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Leaf : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // 가능하다면 이후 json 파일로 수정
            ("안녕? 너 혹시 길을 잃었니?", 2, new string[]{"응", "혼자 해결해볼게"}),
            ("내가 길을 알려줄 수 있는데 \n부탁 하나만 들어줄래?", 2, new string[]{ "뭔데?", "나 바빠.."}),
            ("나는 내 소중한 친구가 \n너무 보고싶어", 0, EMPTY_STRING_ARRAY),
            ("내가 친구에게 선물해주려고 \n찾아놓은 나뭇잎이 있는데 \n잃어버렸어.. 찾아줄래?", 2, new string[]{"나만 믿어", "글쎄.."}),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("널 믿고 있어. 꼭 찾아줘", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("고마워, 친구에게 책갈피로 쓰라고 선물을 해주고 싶어서 찾았던 건데 \n난 지금 너무 늦었어..", 0, EMPTY_STRING_ARRAY),
            ("너도 친구에게 선물을 해보는 건 어때?", 2, new string[]{"어떻게?", "안 하고 싶어.."}),
            ("이 나뭇잎에 그 친구 이름을 새겨서 보내봐 \n엄청난 책갈피가 만들어지겠는걸 ?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("그 친구가 엄청 좋아할꺼야 ! 넌 꼭 전해줬으면 좋겠다 !", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("나뭇잎을 찾았다.", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "쟈스민";

        hasQuest = true;
        loadMark();
        renderMark();
    }

}
