public class Graph
{
    static public bool BFS(int[][] graph, int start, int target)
    {
        Queue<int[]> q = new Queue<int[]>();
        q.Enqueue(graph[start]);

        while (q.Count != 0)
        {
            var node = q.Dequeue();

            if (node.Length == 0)
                continue;

            if (Array.IndexOf(node, target) > -1)
                return true;
            else
            {
                for (int i = 0; i < node.Length; i++)
                    q.Enqueue(graph[node[i]]);
            }

        }

        return false;
    }


    static public Dictionary<char, int> Dejkstra(Dictionary<char, Dictionary<char, int>> graph, char start)
    {
        var costs = new Dictionary<char, int>();
        var processed = new List<char>();
        var node_neibours = new Dictionary<char, int>();

        foreach (var curr_node in graph.Keys)
        {
            if (curr_node != start)
            {
                var path = int.MaxValue;

                if (graph[start].ContainsKey(curr_node))
                    path = graph[start][curr_node];

                costs[curr_node] = path;
            }
        }

        var node = FindNodeLowestCost(costs, processed);

        while (node != '\0')
        {
            var cost = costs[node];
            node_neibours = graph[node];

            foreach (var neibour in node_neibours)
            {
                var newCost = cost + neibour.Value;
                if (newCost < costs[neibour.Key])
                    costs[neibour.Key] = newCost;
            }
            processed.Add(node);

            node = FindNodeLowestCost(costs, processed);

        }

        return costs;
    }

    static char FindNodeLowestCost(Dictionary<char, int> costs, List<char> processed)
    {
        var lowestCost = int.MaxValue;
        char lowestNode = '\0';

        foreach (var node in costs.Keys)
        {
            var cost = costs[node];
            if (cost < lowestCost && !processed.Contains(node))
            {
                lowestCost = cost;
                lowestNode = node;
            }
        }
        return lowestNode;
    }
}

