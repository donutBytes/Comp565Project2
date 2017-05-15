using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGMGSKv8
{
    class NavGraph
    {
        Dictionary<String, NavNode> graph; // Key "x:z"
        List<NavNode> open, closed, path;
        List<NavNode> aStarPath;
    // Example key for graph based on (x,z)
    private String skey(int x, int z)
        {
            return String.Format("{0}::{1}", x, z);
        }

    }
}
