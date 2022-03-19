using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Mountain : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // �����ϴٸ� ���� json ���Ϸ� ����
            ("�ȳ�? �� Ȥ�� ������� �ö� �� �־�?", 2, new string[]{ "��? �׷�!", "���ڱ�..?\n �ƴ�.. ����"}),
            ("�� �ö� ���� ���ŵ�", 0, EMPTY_STRING_ARRAY),
            ("�� ��� �� �� �ö����� ������?", 2, new string[]{ "��վ�̴µ�?", "�̾�.."}),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("�� �����ʿ� ���̴� ������� �� �� �ö����� ������?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("�� ���� �� �ö󰣴�", 0, EMPTY_STRING_ARRAY),
            ("���� �θ������ �ǰ��� ����� ���� ���̰� �;���.. \n�׻� ���Ͱŵ�", 1, new string[]{ "��...", "������ڴ�"}),
            ("�ʵ� � ���ư��� �θ�Բ� �ǰ��� ��� �������", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("�׶��� ����߾�", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("���� �����ߴ�", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "�ɺ�";

        hasQuest = true;
        loadMark();
        renderMark();
    }

}
