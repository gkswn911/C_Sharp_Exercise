using System;
using System.IO;
// 직렬화를 위한 라이브러리
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Example
{
    [Serializable]
    class Node
    {
        private string data;
        public Node(string data)
        {
            this.data = data;
        }
        public void Print()
        {
            Console.WriteLine(this.data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node("Test");
            // 직렬화 클래스
            var formatter = new BinaryFormatter();
            // 클래스를 직렬화하여 보관할 데이터
            byte[] data;
            using(MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, node);
                data = new byte[stream.Length];
                //스트림을 byte[] 데이터로 변환한다.
                data = stream.GetBuffer();
            }
            using(MemoryStream stream = new MemoryStream())
            {
                // byte를 읽어들인다.
                stream.Write(data, 0, data.Length);
                // Stream seek을 맨 처음으로 돌린다.
                stream.Seek(0, SeekOrigin.Begin);
                // 클래스를 역직렬화 하고 Node클래스의 Print함수 실행.
                ((Node)formatter.Deserialize(stream)).Print();
            }
            // 직렬화 데이터를 파일로 저장한다.
            using(FileStream stream = new FileStream("d:\\work\\Serializable.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, node);
            }
            // 파일로 부터 직렬화 데이터를 읽어들인다.
            using (FileStream stream = new FileStream("d:\\work\\Serializable.dat", FileMode.Open, FileAccess.Read))
            {
                // 클래스를 역직렬화 하고 Node클래스의 Print함수 실행.
                ((Node)formatter.Deserialize(stream)).Print();
            }
            Console.WriteLine("Press any key...");
            
            Console.ReadKey();
        }
    }
}
