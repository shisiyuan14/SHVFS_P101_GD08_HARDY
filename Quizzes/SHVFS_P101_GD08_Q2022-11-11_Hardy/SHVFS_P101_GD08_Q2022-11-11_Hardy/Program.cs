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
            GameObject[] go = new GameObject[5];
            go[0]=new GameObject("1",new Position(1,2,3));
            go[1] = new GameObject("2", new Position(2, 1, 3));
            go[2] = new GameObject("3", new Position(3, 4, 35));
            go[3] = new GameObject("4", new Position(1, 2, 3));
            go[4] = new GameObject("5", new Position(15, 25, 53));

            for(int i=0; i< go.Length-1; i++)
            {
                for(int j=i+1; j<go.Length;j++)
                {
                    if (go[i].Judge(go[j]))
                    {
                        Console.WriteLine($"{go[i].name} and {(go[j].name)} have the same position");
                    }
                    
                }
            }

        }




        public struct Position
        {
            public float x, y, z;
            public Position(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;

            }

        }
        public class GameObject
        {
            
            public string name;
            
            public Position position;

            
           
            public GameObject( string name, Position position)
            {
                this.position = position;
                this.name = name;
            }
            

            public bool Judge(GameObject go)
            {
                
                if(go.position.x== position.x && go.position.y == position.y && go.position.z == position.z)
                {
                    return true;
                }
                return false;
            }


        }
    }
}


    













