using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Picture : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // �����ϴٸ� ���� json ���Ϸ� ����
            (". . .", 1, new string[]{"����?", "�ȳ�"}),
            ("Ȥ�� �� ���� �� �ô�?", 2, new string[]{ "���� ã���ٱ�?", "�� ã�ƺ�"}),
            ("�׷� �ʹ� ����... \n�� ã����..", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("ã�� �־�?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("���� ���� !!", 0, EMPTY_STRING_ARRAY),
            ("��� ������� ��, �� ������� ������ �߾��̰ŵ�", 1, new string[]{"�׷�����...", "��Ÿ����..."}),
            ("�̰� �� �״ϱ� �� ������ ������� �߾��� ���� ���ܳ�", 0, EMPTY_STRING_ARRAY),
            ("�� ���� �ʿ� �����ϱ�", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("����, ã���༭ ����", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("������ ã�Ҵ�.", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "���̳�";
        hasQuest = true;
        loadMark();
        renderMark();
    }

}
