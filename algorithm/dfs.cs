using System;

namespace dfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.DFS(3);
        }
    }

    class Graph
    {
        int [,] arr = new int [6,6]
        {
            {0, 1, 1, 0},
            {1, 0, 1, 0},
            {1, 1, 0, 1},
            {0, 0, 1, 0},
        };        

        // 방문 체크
        bool [] visited = new bool [6];

        public void DFS(int num) // 순회 시작 위치가 인수로 들어온다.
        {
            System.Console.WriteLine(num);
            visited[num] = true;

            // 미 방문 상태의 노드만 방문한다.
            // DFS라서 깊은 노드에 먼저 방문한다.
            for(int next = 0; next < 4; next++)
            {
                if(arr[num, next] == 0) // 연결 되어 있지 않으면 스킵
                    continue;
                if(visited[next]) // 이미 방문했으면 스킵
                    continue;
                DFS(next);
            }
        }
    }
}
