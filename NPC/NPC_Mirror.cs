using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Mirror : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // �����ϴٸ� ���� json ���Ϸ� ����
            ("�ȵ� �ȵ�!", 1, new string[]{ "���� ���̾�?", "����ݾ� ! ��������"}),
            ("�߿��� ������ �Ҿ���Ⱦ�.", 1, new string[]{ "�װ� ����?", "���?"}),
            ("������ �ſ��̶�� \n���� ���� �Ƴ��� �ſ��̾�.", 1, new string[]{ "�ſ￡ ������ ����?", "������ �ſ��̶�..."}),
            ("�ڽ��� ���� ����ϴ� ����� ������,\n���� �����ٷ�?", 0, EMPTY_STRING_ARRAY),
            ("�� �ſ� �� ã���� �� ������?", 2, new string[]{"��!", "�ƴ�"}),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("�ſ��� ã�Ƽ� ������ ������ ��...", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("ã�ұ���..! �� �ְ��. \n�� �ſ�� �ʵ� ������ Ȯ���غ���?", 1, new string[]{ "��? �� ���� ��������?", "�̰� �׳� �ſ� �ƴϾ�?"}),
            ("�� �ſ��� �ڽ��� ���� ����ϴ� ����� ������, \n�Ƹ� ���� ���鿡�� �ʸ� ���� ����ϰ� �ִ� �ž� ", 1, new string[]{ "����?", "�׷�?"}),
            ("�׷� ~ �ڽ��� ����ϴ� �����ŭ ���� �� ���� �ž�. \nȤ�� �ٸ� ����� �����鵵 Ȯ���غ��� �ʹ�?", 1, new string[]{"��", "����!!"}),
            ("Ȯ���غ��� ���� ������� �� �ſ��� ��������", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("�� ��� ������ Ȯ���غô�?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("�ſ��� ã�Ҵ�.", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "�ŵ�";

        hasQuest = true;
        loadMark();
        renderMark();
    }

}
