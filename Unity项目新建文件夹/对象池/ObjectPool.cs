using System.IO;
using System.Xml;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectPool 
{
   
        //创建了一个私有静态的类类型的变量（该类的对象，将该变量置空）
        private static ObjectPool _instance =null;
        //私有构造函数，保证只能有一个对象，保证了安全性
        private ObjectPool()
        {
        }
        //属性
        public static ObjectPool Instance
        {
            //可以获取这个属性
            get
            {
                //如果该类的对象为空，则实例化一个出来
                if (_instance == null)
                {
                    _instance = new ObjectPool();
                }
                //否则直接返回该对象
                return _instance;
            }
        }


    //存储数据部分
    //使用键值对存放对象池中的游戏物体GameObject
    Dictionary<string, List<GameObject>> pool = new Dictionary<string, List<GameObject>>();
}


