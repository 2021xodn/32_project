using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Letter : AbstractNPC {
    private void Start() {            // �� NPC���� �ʱ� ����
        DIALOG_BEFORE = new (string, int, string[])[] {
            ("���� ��ް� �ִ� �ž�?", 2, new string[]{ "��", "�ƴ�"}),
            ("���� ���� �˷��� �� �ִµ�!", 2, new string[]{ "���?", "�ʿ� ����"}),
            ("���� �θ�Բ� �� ������ �Ҿ���Ⱦ�...\nã���ָ� ���� ���� �˷��ٰ�", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST= new (string, int, string[])[] {
            ("ã�� �ִ� ����?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR= new (string, int, string[])[] {
            ("���� ã�ƿ� ���̾�! �����̾�...", 0, EMPTY_STRING_ARRAY),
            ("��� �̰��� ���� ���� �θ�Բ� \n���� �ηȴ� �� �ʹ� ��ȸ��", 0, EMPTY_STRING_ARRAY),
            ("�׷��� �� �����ε� �� �̹� �帱 ���� ����...\n�ʵ� �θ�Բ� ������ �Ἥ ������ ������ ��", 3, new string[]{"��", "�ƴ� �� �ҷ�"}),
            ("", 0, EMPTY_STRING_ARRAY)
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("�θ���� ���� ���� �ްڴ�..\n�� ���� �θ���� ���� ������ �ڽ��̾� �׻� ����!", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("Ǯ ������ ������ ã�Ҵ� !", 0, EMPTY_STRING_ARRAY),
            ("", 0,EMPTY_STRING_ARRAY),
        };

        test = new (string, int, string[])[] {
            ("����Ƽ", 0, new string[]{"", ""}),
            ("�η�", 1, new string[]{"��", "��"}),
            ("", 0, new string[]{"", "1"}),
        };

        NPC_NAME = "�ٸ���";


        hasQuest = true;
        loadMark();
        renderMark();
    }

}
