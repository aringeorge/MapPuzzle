using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPuzzle
{
   class Map
   {
      public const int Map_Size = 10;
      public const int Num_10_Bonus = 2;
      public const int Value_10_Bonus = 10;
      public const int Num_5_Bonus = 5;
      public const int Value_5_Bonus = 5;
      public const int Num_3_Bonus = 8;
      public const int Value_3_Bonus = 3;

      Tile[,] m_sMapTiles;

      public Map()
      {
         m_sMapTiles = new Tile[Map_Size, Map_Size];
      }

      public bool IsTileEndTile(int nXVal, int nYVal)
      {
         return m_sMapTiles[nXVal, nYVal].GetEnd();
      }

      public short GetTileMovementBonus(int nXVal, int nYVal)
      {
         return m_sMapTiles[nXVal, nYVal].GetBonus();
      }

      public bool IsTileCovered(int nXVal, int nYVal)
      {
         return m_sMapTiles[nXVal, nYVal].IsCovered();
      }

      public void UncoverTile(int nXVal, int nYVal)
      {
         m_sMapTiles[nXVal, nYVal].SetCovered(false);
      }

      public void InitializeNewMap()
      {
         int lDateTime = (int)(DateTime.Now.Ticks % int.MaxValue);
         Random sRnd = new Random(lDateTime);

         for (short i = 0; i < Map_Size; i++)
         {
            for (short j = 0; j < Map_Size; j++)
            {
               m_sMapTiles[i, j] = new Tile();
               m_sMapTiles[i, j].SetLocation(i, j);
               m_sMapTiles[i, j].SetMoveBonus(0);
               m_sMapTiles[i, j].SetEndTile(false);
               m_sMapTiles[i, j].SetCovered(true);
            }
         }

         int lEndX = sRnd.Next(Map_Size / 2 - 1, Map_Size);
         int lEndY = sRnd.Next(Map_Size / 2 - 1, Map_Size);
         m_sMapTiles[lEndX, lEndY].SetEndTile(true);

         int l10Bonuses = 0;
         do
         {
            int lXVal = sRnd.Next(Map_Size - 1);
            int lYVal = sRnd.Next(Map_Size - 1);
            if ((lXVal != 0) && (lYVal != 0) && (m_sMapTiles[lXVal, lYVal].GetBonus() == 0) && (m_sMapTiles[lXVal, lYVal].GetEnd() == false))
            {
               m_sMapTiles[lXVal, lYVal].SetMoveBonus(Value_10_Bonus);
               l10Bonuses++;
            }
         }
         while (l10Bonuses != Num_10_Bonus);

         int l5Bonuses = 0;
         do
         {
            int lXVal = sRnd.Next(Map_Size - 1);
            int lYVal = sRnd.Next(Map_Size - 1);
            if ((lXVal != 0) && (lYVal != 0) && (m_sMapTiles[lXVal, lYVal].GetBonus() == 0) && (m_sMapTiles[lXVal, lYVal].GetEnd() == false))
            {
               m_sMapTiles[lXVal, lYVal].SetMoveBonus(Value_5_Bonus);
               l5Bonuses++;
            }
         }
         while (l5Bonuses != Num_5_Bonus);

         int l3Bonuses = 0;
         do
         {
            int lXVal = sRnd.Next(Map_Size - 1);
            int lYVal = sRnd.Next(Map_Size - 1);
            if ((lXVal != 0) && (lYVal != 0) && (m_sMapTiles[lXVal, lYVal].GetBonus() == 0) && (m_sMapTiles[lXVal, lYVal].GetEnd() == false))
            {
               m_sMapTiles[lXVal, lYVal].SetMoveBonus(Value_3_Bonus);
               l3Bonuses++;
            }
         }
         while (l3Bonuses != Num_3_Bonus);
      }
   }
}
