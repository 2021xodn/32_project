using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Leaf : AbstractNPC {
    private void Start() {            // NPC Settings
        DIALOG_BEFORE = new (string, int, string[])[] {  // �����ϴٸ� ���� json ���Ϸ� ����
            ("�ȳ�? �� Ȥ�� ���� �Ҿ���?", 2, new string[]{"��", "ȥ�� �ذ��غ���"}),
            ("���� ���� �˷��� �� �ִµ� \n��Ź �ϳ��� ����ٷ�?", 2, new string[]{ "����?", "�� �ٺ�.."}),
            ("���� �� ������ ģ���� \n�ʹ� ����;�", 0, EMPTY_STRING_ARRAY),
            ("���� ģ������ �������ַ��� \nã�Ƴ��� �������� �ִµ� \n�Ҿ���Ⱦ�.. ã���ٷ�?", 2, new string[]{"���� �Ͼ�", "�۽�.."}),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_QUEST = new (string, int, string[])[] {
            ("�� �ϰ� �־�. �� ã����", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_CLEAR = new (string, int, string[])[] {
            ("����, ģ������ å���Ƿ� ����� ������ ���ְ� �; ã�Ҵ� �ǵ� \n�� ���� �ʹ� �ʾ���..", 0, EMPTY_STRING_ARRAY),
            ("�ʵ� ģ������ ������ �غ��� �� �?", 2, new string[]{"���?", "�� �ϰ� �;�.."}),
            ("�� �����ٿ� �� ģ�� �̸��� ���ܼ� ������ \n��û�� å���ǰ� ��������ڴ°� ?", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_AFTER = new (string, int, string[])[] {
            ("�� ģ���� ��û �����Ҳ��� ! �� �� ���������� ���ڴ� !", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        DIALOG_ITEM = new (string, int, string[])[] {
            ("�������� ã�Ҵ�.", 0, EMPTY_STRING_ARRAY),
            ("", 0, EMPTY_STRING_ARRAY),
        };

        NPC_NAME = "�𽺹�";

        hasQuest = true;
        loadMark();
        renderMark();
    }

}
