using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public static class PathFinder
{
    public static void jaVisitou()
    {
        Debug.Log("voce por aqui de novo?");
    }
	public static List<Grid.Position> FindPath( Tile[,] tiles, Grid.Position fromPosition, Grid.Position toPosition)
	{
		var path = new List<Grid.Position>();
      
        List<Grid.Position> lista = new List<Grid.Position> { };
        Queue<Grid.Position> Q1 = new Queue<Grid.Position>();
        Q1.Enqueue(fromPosition);
       

        while (Q1.Count > 0)
        {
            Grid.Position p = Q1.Dequeue();

            if (p.x == toPosition.x && p.y == toPosition.y)
            {
                Debug.Log("Achei o cara");
                break;
            }
            else
            {
                Grid.Position seeker1 = new Grid.Position { x = p.x, y = p.y + 1 };
                Grid.Position seeker2 = new Grid.Position { x = p.x, y = p.y - 1 };
                Grid.Position seeker3 = new Grid.Position { x = p.x + 1, y = p.y };
                Grid.Position seeker4 = new Grid.Position { x = p.x + 1, y = p.y };

                if (lista.Contains(seeker1)) { Q1.Enqueue(seeker1); }
                if (lista.Contains(seeker2)) { Q1.Enqueue(seeker2); }
                if (lista.Contains(seeker3)) { Q1.Enqueue(seeker3); }
                if (lista.Contains(seeker4)) { Q1.Enqueue(seeker4); }

                lista.Add(seeker1);
                lista.Add(seeker2);
                lista.Add(seeker3);
                lista.Add(seeker4);

                if(toPosition.x == seeker1.x && toPosition.y == seeker1.y)
                {
                    jaVisitou();
                }
                if (toPosition.x == seeker2.x && toPosition.y == seeker2.y)
                {
                    jaVisitou();
                }
                if (toPosition.x == seeker3.x && toPosition.y == seeker3.y)
                {
                    jaVisitou();
                }
                if (toPosition.x == seeker4.x && toPosition.y == seeker4.y)
                {
                    jaVisitou();
                }
            }
                
        }

        path.Add( fromPosition );
        Grid.Position posi = fromPosition;

        /*while(posi.x != toPosition.x || posi.y != toPosition.y)
        {
            if(posi.x < toPosition.x)
            { posi.x++; }
            else if (posi.x>toPosition.x) { posi.x--; }

            if (posi.y < toPosition.y)
            { posi.y++; }
            else if (posi.y> toPosition.y) { posi.y--; }
           
            path.Add(posi);
        }*/
        
        path.Add(toPosition);
        return path;
	}
}