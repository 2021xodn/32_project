using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_test : AbstractNPC {
    //static string name;
    private void Start() {
        BEFORE_DIALOG = new string[] {  // �����ϴٸ� ���� json ���Ϸ� ����
            "���� ��ȭ0",
            "���� ��ȭ1",
            "���� ��ȭ2"
        };
        AFTER_DIALOG = new string[] {  // �����ϴٸ� ���� json ���Ϸ� ����
            "���� ��ȭ0",
            "���� ��ȭ1",
            "���� ��ȭ2"
        };
    }

}
