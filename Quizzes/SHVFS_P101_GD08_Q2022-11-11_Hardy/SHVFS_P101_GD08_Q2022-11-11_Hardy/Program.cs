using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD08_Hardy
{

    class program
    {
        public static void Main(string[] args)
        {

            var GameObject1=new GameObject(0,0,0,"1");
            var GameObject2 = new GameObject(1, 1, 1,"2");
            var GameObject3 = new GameObject(2, 2, 2,"3");
            var GameObject4 = new GameObject(0, 0, 0,"4");
            var GameObject5 = new GameObject(4, 4, 4,"5");


        }


        public class GameObject
        {
            public int x, y, z;
            public string name;
            
            public string Name(string name)
            {
                return name;
            }
            public GameObject(int x, int y, int z, string name)
            {
                x = x;
                y = y;
                z = z;

            }
            public struct Position
            {
                public int x, y, z;
                

            }

            public bool Judge(bool GameObject1)
            {
                
                return GameObject1;
            }


        }
    }
}


    













