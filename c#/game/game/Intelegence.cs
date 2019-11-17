using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Intelegence
    {
        public string character;
        public bool state;
        public int[,] a = new int[3, 3] { {0, 0, 0}, {0, 0, 0}, {0, 0, 0} }; 
        public Intelegence(string c, bool s)
        {
            state = s;
            character = c;
        }
        public void realAI()
        {
            int idx1 = -1;
            int idx2 = -1;
            int cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for(int j = 0; j < 3; j++)
                {
                    if (a[i, j] == 2) cnt++;
                    if(a[i, j] == 0)
                    {
                        idx1 = i;
                        idx2 = j;
                    }
                }
                if(cnt == 2)
                {
                    if(idx1 != -1 && idx2 != -1)
                    {
                        a[idx1, idx2] = 1;
                        return;
                    }
                }
                else
                {
                    idx1 = -1;
                    idx2 = -1;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (a[j, i] == 2) cnt++;
                    if (a[j, i] == 0)
                    {
                        idx1 = i;
                        idx2 = j;
                    }
                }
                if (cnt == 2)
                {
                    if (idx1 != -1 && idx2 != -1)
                    {
                        a[idx2, idx1] = 1;
                        return;
                    }
                }
                else
                {
                    idx1 = -1;
                    idx2 = -1;
                }
            }
            cnt = 0;
            if (a[0, 0] == 2) cnt++;
            if (a[1, 1] == 2) cnt++;
            if (a[2, 2] == 2) cnt++;
            if(cnt == 2)
            {
                if(a[0,0] == 0)
                {
                    a[0, 0] = 1;
                    return;
                }
                if (a[1, 1] == 0)
                {
                    a[1, 1] = 1;
                    return;
                }
                if (a[2, 2] == 0)
                {
                    a[2, 2] = 1;
                    return;
                }
            }
            cnt = 0;
            if (a[0, 2] == 2) cnt++;
            if (a[1, 1] == 2) cnt++;
            if (a[2, 0] == 2) cnt++;
            if (cnt == 2)
            {
                if (a[0, 2] == 0)
                {
                    a[0, 2] = 1;
                    return;
                }
                if (a[1, 1] == 0)
                {
                    a[1, 1] = 1;
                    return;
                }
                if (a[2, 0] == 0)
                {
                    a[2, 0] = 1;
                    return;
                }
            }
            idx1 = -1;
            idx2 = -1;
            cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] == 1) cnt++;
                    if (a[i, j] == 0)
                    {
                        idx1 = i;
                        idx2 = j;
                    }
                }
                if (cnt == 2)
                {
                    if (idx1 != -1 && idx2 != -1)
                    {
                        a[idx1, idx2] = 1;
                        return;
                    }
                }
                else
                {
                    idx1 = -1;
                    idx2 = -1;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (a[j, i] == 1) cnt++;
                    if (a[j, i] == 0)
                    {
                        idx1 = i;
                        idx2 = j;
                    }
                }
                if (cnt == 2)
                {
                    if (idx1 != -1 && idx2 != -1)
                    {
                        a[idx2, idx1] = 1;
                        return;
                    }
                }
                else
                {
                    idx1 = -1;
                    idx2 = -1;
                }
            }
            cnt = 0;
            if (a[0, 0] == 1) cnt++;
            if (a[1, 1] == 1) cnt++;
            if (a[2, 2] == 1) cnt++;
            if (cnt == 2)
            {
                if (a[0, 0] == 0)
                {
                    a[0, 0] = 1;
                    return;
                }
                if (a[1, 1] == 0)
                {
                    a[1, 1] = 1;
                    return;
                }
                if (a[2, 2] == 0)
                {
                    a[2, 2] = 1;
                    return;
                }
            }
            cnt = 0;
            if (a[0, 2] == 1) cnt++;
            if (a[1, 1] == 1) cnt++;
            if (a[2, 0] == 1) cnt++;
            if (cnt == 2)
            {
                if (a[0, 2] == 0)
                {
                    a[0, 2] = 1;
                    return;
                }
                if (a[1, 1] == 0)
                {
                    a[1, 1] = 1;
                    return;
                }
                if (a[2, 0] == 0)
                {
                    a[2, 0] = 1;
                    return;
                }
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(a[i, j] == 0)
                    {
                        a[i, j] = 1;
                        return;
                    }
                }
            }
        }
    }
}
