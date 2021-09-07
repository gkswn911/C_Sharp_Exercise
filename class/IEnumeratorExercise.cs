// 아래 함수 3가지를 강제로 구현해야하는 인터페이스다.
// public interface IEnumerator
// {
//     object Current { get; }
//     bool MoveNext();
//     void Reset();
// }
//
// public interface IEnumerable
// {
//     IEnumerator GetEnumerator();
// }

using System;
using System.Collections;

class Member
{
    public int Id
    {
        get => Id;
        private set => Id = value;
    }

    public string Name
    {
        get => Name;
        private set => Name = value;
    }

    public Member(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return string.Format("아이디:{0} 이름:{1}", Id, Name);
    }
}

// 객체 반환을 위해서는 선언 되어야하는 클래스.
// 빌더 패턴과 유사
class MemberCollection : IEnumerable
{
        var arr = new ArrayList();

        // 내부 컬렉션을 이용하여 IEnumerator 반환
        // 객체 반환을 위해서는 선언되어야한다.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return arr.GetEnumerator(); 
        }

        public void AddMember(Member member)
        {
            arr.Add(member);
        }
}

class Program
{
    static void Main(string[] args)
    {
        var mc = new MemberCollection();
        mc.AddMember(new Member(1,"David"));
        mc.AddMember(new Member(2,"Lee"));

        foreach (Member member in mc)
        {
            Console.WriteLine(member.ToString());
        }

    }
}


