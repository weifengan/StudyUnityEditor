using UnityEngine;
using System.Collections;
using UnityEditor;

public class MenuItemExample : MonoBehaviour
{
    //普通菜单栏添加菜单项
    [MenuItem("Tools/MenuItem1",false,2)]
    private static void CreateMenuItem1() { 
        Debug.Log("Click MenuItem1");
    }

    [MenuItem("Tools/MenuItem2")]
    private static void CreateMenuItem2() { 
        Debug.Log("Click MenuItem2");
    }

    

    //其它状态的菜单
    [MenuItem("Tools/MenuItem3", false, 1)]
    private static void CreateMenuItem3()
    {
        Debug.Log("Click MenuItem3");
    }

    //"Tools/MenuItem1"需要和上面的一样；true表示该方法是验证方法
    [MenuItem("Tools/MenuItem4", false, 3)]
    private static bool CreateMenuItem4Validate()
    {
        //返回false，表示当前菜单项不可见
        return true;
    }



    //Hierachy上下文菜单
    [MenuItem("GameObject/Hierarchy MenuItem", false, 0)]
    static void CreateHierarchyMenuItem() {
        Debug.Log("Click Hierarchy MenuItem");
    }

    //Project的上下文菜单 
    [MenuItem("Assets/Project MenuItem")]
    static void CreateProjectMenuItem()
    {
        Debug.Log("Click Project MenuItem");
    }

    //Componet的上下文菜单 
    [MenuItem("CONTEXT/Camera/摄像机菜单项")]
    private static void TransformMenu() {
        Debug.Log("你点击了摄像机");
    }


    [MenuItem("CONTEXT/Transform/Transform MenuItem2")]
    private static void TransformMenu2(MenuCommand menuCommand){
        Debug.Log(menuCommand.context.name);
        //得到当前选中的对象类型Transform
        Transform transform = menuCommand.context as Transform;
        Debug.Log(transform.localPosition);
    }



}
